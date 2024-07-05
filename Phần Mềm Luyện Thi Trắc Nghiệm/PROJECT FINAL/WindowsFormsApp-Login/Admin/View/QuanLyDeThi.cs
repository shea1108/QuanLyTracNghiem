using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.Controller;
using WindowsFormsApp_Login.User.Model;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;


namespace WindowsFormsApp_Login.Admin.View
{
    public partial class QuanLyDeThi : UserControl
    {
        List<Exam> exams = new List<Exam>();
        List<Subject> subject = new List<Subject>();
        ExamModify examModify = new ExamModify();
        public QuanLyDeThi()
        {
            InitializeComponent();

            subject = examModify.GetSubject("SELECT * FROM list_subject ");
            exams = examModify.GetExams("SELECT * FROM list_exam ");
            ShowData();
            ShowSubject();

        }
        private void ShowData()
        {
            exams = examModify.GetExams("SELECT * FROM list_exam  ");

            listEx_table.Rows.Clear();
            listEx_table.Refresh();
            foreach (Exam ex in exams)
            {
                // Thêm một hàng mới vào CustomDataGridView với dữ liệu tương ứng
                listEx_table.Rows.Add(
                listEx_table.Rows.Count,
                ex.Id_exam,
                ex.Name_exam,
                ex.Exam_number,
                ex.Number_question,
                ex.Time + " phút"
            );
            }
        }
        private void ShowSubject()
        {
            foreach (Subject subjects in subject)
            {
                cB_tende.Items.Add(subjects.NameExam);
            }
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
                if (cB_tende.SelectedItem == null || string.IsNullOrEmpty(tB_deso.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin đề thi.");
                    return;
                }
                string selectedName = cB_tende.Texts;
                int number_exam = int.Parse(tB_deso.Text);
                foreach (Exam exm in exams)
                {
                    if (exm.Name_exam.Equals(selectedName) && exm.Exam_number == number_exam)
                    {
                        MessageBox.Show("Đề thi với mã đề đã tồn tại trong " + selectedName + ".");
                        return;
                    }
                }
                int soCau = int.Parse(cB_socau.SelectedItem.ToString());
                int thoiGian = int.Parse(cB_time.SelectedItem.ToString());

                Exam ex = new Exam(selectedName,number_exam, soCau, thoiGian);
                ExamModify examModify = new ExamModify();

                string query = "SELECT * FROM list_exam ";
                exams = examModify.GetExams(query);

                int id_ex = exams[exams.Count - 1].Id_exam;
                AddOption ap = new AddOption(id_ex+1, selectedName,number_exam, soCau, thoiGian);
                ap.ShowDialog();

                listEx_table.Refresh();
                ShowData();
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Vui lòng chọn một đề để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa đề này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                ExamModify.Delete(selectedId);
                ExamModify.DeleteQuestion(selectedId);
                MessageBox.Show("Đã xóa đề thành công !");
                listEx_table.Rows.Clear();
                ShowData();
                listEx_table.Refresh();
                cB_tende.Texts = "";
                tB_deso.Text = "";
                cB_socau.Text = "";
                cB_time.Text = "";
                selectedId = 0;
            }
        }
        private void cB_tende_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = cB_tende.SelectedItem.ToString();
            var matchingExams = exams.Where(ex => ex.Name_exam == selectedName).ToList();
            int numberExam = matchingExams.Count + 1;
            tB_deso.Text = numberExam.ToString();
        }
        private void listEx_table_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Clicks == 2)
            {
                int id_ex = Convert.ToInt32(listEx_table.Rows[e.RowIndex].Cells["ID"].Value);
                string nameExam = (string)listEx_table.Rows[e.RowIndex].Cells["NameExam"].Value;
                int numberExam = Convert.ToInt32(listEx_table.Rows[e.RowIndex].Cells["NumberExam"].Value);
                int soCau = Convert.ToInt32(listEx_table.Rows[e.RowIndex].Cells["SoCau"].Value);

                EditQuestion editForm = new EditQuestion(id_ex, nameExam, numberExam, soCau);
                editForm.ShowDialog();

            }
        }
        int selectedId;
        private void listEx_table_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int rowIndex = listEx_table.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    DataGridViewRow row = listEx_table.Rows[rowIndex];


                    selectedId = Convert.ToInt32(row.Cells["id"].Value);


                    string query = "SELECT * FROM list_exam WHERE Id_Exam = " + selectedId;


                    ExamModify examModify = new ExamModify();
                    List<Exam> selectedExamData = examModify.GetExams(query);


                    if (selectedExamData.Count > 0)
                    {
                        cB_tende.Texts = selectedExamData[0].Name_exam;
                        cB_socau.Text = selectedExamData[0].Number_question.ToString();
                        tB_deso.Text = selectedExamData[0].Exam_number.ToString();
                        cB_time.Text = selectedExamData[0].Time.ToString();
                    }
                }
            }
        }
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            listEx_table.Rows.Clear();
            ShowData();
            listEx_table.Refresh();
        }
        private static DialogResult InputBox(string title, string promptText, ref Subject selectedSubject, List<Subject> subjects)
        {
            Form form = new Form();
            Label label = new Label();
            ComboBox comboBox = new ComboBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            foreach (Subject subject in subjects)
            {
                comboBox.Items.Add(subject.NameExam);
            }

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            comboBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            comboBox.Anchor = comboBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new System.Drawing.Size(396, 107);
            form.Controls.AddRange(new Control[] { label, comboBox, buttonOk, buttonCancel });
            form.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string selectedName = comboBox.Text;
                selectedSubject = subjects.FirstOrDefault(s => s.NameExam == selectedName);
            }

            return dialogResult;
        }
        private void tim_kiemBtn_Click(object sender, EventArgs e)
        {
            Subject selectedSubject = null;
            DialogResult result = InputBox("Chọn môn học", "Chọn một môn học:", ref selectedSubject, subject);
            if (result == DialogResult.OK && selectedSubject != null)
            {
                string querryTimkiem = "SELECT * FROM list_exam WHERE Name_Exam LIKE '%" + selectedSubject.NameExam + "%'";                
                listEx_table.Rows.Clear();             
                foreach (Exam ex in exams)
                {
                    if (ex.Name_exam.Contains(selectedSubject.NameExam))
                    {
                        
                        listEx_table.Rows.Add(
                            listEx_table.Rows.Count,
                            ex.Id_exam,
                            ex.Name_exam,
                            ex.Exam_number,
                            ex.Number_question,
                            ex.Time
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn môn học hoặc đã hủy bỏ.");
            }
        }
    }
}


