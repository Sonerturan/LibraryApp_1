using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp_1
{
    public partial class PageStudents : Form
    {
        StudentManager studentManager = new StudentManager();
        public PageStudents()
        {
            InitializeComponent();
        }

        private void PageStudents_Load(object sender, EventArgs e)
        {
            ListBase();
        }
        public void ListBase()
        {
            dgwlist.DataSource = studentManager.ListBase();
        }
        public void ListSearch(string searchcontent)
        {
            dgwlist.DataSource = studentManager.ListSearch(searchcontent);
        }
        public void textboxClear()
        {
            txtstudentid.Text = "";
            txtstudentname.Text = "";
            txtstudentsurname.Text = "";
            txtstudentphone.Text = "";
            txtdepartment.Text = "";
            txtclass.Text = "";
            cbxgender.Text = "";
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            btnsearch.Visible = false;
            txtsearch.Text = "";
            pctrsearch.Visible = true;
            txtsearch.Visible = true;
        }

        private void pctrsearch_Click(object sender, EventArgs e)
        {
            btnsearch.Visible = true;
            pctrsearch.Visible = false;
            txtsearch.Visible = false;
            ListSearch(txtsearch.Text);
        }

        private void pctrrefresh_Click(object sender, EventArgs e)
        {
            ListBase();
            btnsearch.Visible = true;
            pctrsearch.Visible = false;
            txtsearch.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string studentid = dgwlist.CurrentRow.Cells["Öğrenci No"].Value.ToString().ToLower().Trim();
            string studentname = dgwlist.CurrentRow.Cells["AD"].Value.ToString().ToLower().Trim();
            string studentusername = dgwlist.CurrentRow.Cells["SOYAD"].Value.ToString().ToLower().Trim();
            string studentphone = dgwlist.CurrentRow.Cells["TELEFON"].Value.ToString().ToLower().Trim();
            string department = dgwlist.CurrentRow.Cells["BÖLÜM"].Value.ToString().ToLower().Trim();
            string iclass = dgwlist.CurrentRow.Cells["SINIF"].Value.ToString().ToLower().Trim();
            string gender = dgwlist.CurrentRow.Cells["CİNSİYET"].Value.ToString().ToLower().Trim();
            DateTime dateofbirth = Convert.ToDateTime(dgwlist.CurrentRow.Cells["Doğum Tarihi"].Value);
            if (gender != "erkek" && gender != "kadın" && gender != "kadin")
            {
                MessageBox.Show(gender + " Olan cinsiyeti 'Erkek' veya 'Kadın' olarak düzeltin !", "Hatalı Cinsiyet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dg = MessageBox.Show(studentid + " Numaralı işlem Güncellensin mi ?", "GÜNCELLE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if (dg == DialogResult.Yes)
                {
                    Student student = new Student
                    {
                        StudentId = studentid,
                        StudentName = studentname,
                        StudentSurname = studentusername,
                        StudentPhone = studentphone,
                        Department = department,
                        Class= iclass,
                        Gender = gender,
                        DateOfBirth = dateofbirth
                    };
                    studentManager.Update(student);
                    ListBase();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string studentid = dgwlist.CurrentRow.Cells["Öğrenci No"].Value.ToString().ToLower().Trim();

            DialogResult dg = MessageBox.Show(studentid + " Numaralı öğrenci silinsin mi?", "SİL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                Student student = new Student
                {
                    StudentId = studentid
                };
                studentManager.Delete(student);
                ListBase();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtstudentid.Text == "" || txtstudentname.Text == "" || txtstudentsurname.Text == "" || txtdepartment.Text == "" || txtstudentphone.Text == "" || txtclass.Text == "" || cbxgender.Text == "")
            {
                lblerror.Text = "Lütfen boş alan bırakmayınız";
            }
            else
            {

                lblerror.Text = null;
                if (studentManager.registeredStudentId(txtstudentid.Text) == txtstudentid.Text.ToLower().Trim())
                {
                    MessageBox.Show(txtstudentid.Text + " No'lu öğrenci sistemde Zaten mevcut", "Mevcut olan öğrenci ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtstudentid.TextLength != 11 )
                {
                    lblerror.Text = " öğrenci numaranız 11 haneli olmalıdır !";
                }
                else if (cbxgender.Text.Trim().ToLower() != "erkek" && cbxgender.Text.Trim().ToLower() != "kadın")
                {
                    lblerror.Text = "'" + cbxgender.Text + "' Hatalı cinsiyet girişi !";
                }
                else
                {
                    Student student = new Student
                    {
                        StudentId = txtstudentid.Text.ToLower().Trim(),
                        StudentName = txtstudentname.Text.ToLower().Trim(),
                        StudentSurname = txtstudentsurname.Text.ToLower().Trim(),
                        StudentPhone = txtstudentphone.Text.ToLower().Trim(),
                        Department = txtdepartment.Text.ToLower().Trim(),
                        Class =txtclass.Text.ToLower().Trim(),
                        Gender = cbxgender.Text.ToLower().Trim(),
                        DateOfBirth = Convert.ToDateTime(dtdateofbirth.Text),
                    };
                    studentManager.Add(student);
                    ListBase();
                    textboxClear();
                }
            }
        }
    }
}
