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
    public partial class PageProccess : Form
    {
        string querysearch = "";
        DateTime nowdate = DateTime.Now;
        ProccesManager proccesManager = new ProccesManager();
        public PageProccess()
        {
            InitializeComponent();
        }
        private void PageProccess_Load(object sender, EventArgs e)
        {
            dtissuedate.MinDate = DateTime.Now.AddDays(7);
            dtpurhasedate.Text = nowdate.ToString();
            dtpurhasedate.Enabled = false;
            ListBase();
        }
        public void ListBase()
        {
            dgwlist.DataSource = proccesManager.ListBase();
        }
        public void ListSearch(string searchcotent)
        {
            dgwlist.DataSource = proccesManager.ListSearch(searchcotent);
        }
        public void ListLateProccessing()
        {
            dgwlist.DataSource = proccesManager.ListLateProccessing();
        }
        public void ListUpComingProcess()
        {
            dgwlist.DataSource = proccesManager.ListUpComingProcess();
        }

        private void pctrrefresh_Click(object sender, EventArgs e)
        {
            ListBase();
            btnsearch.Visible = true;
            pctrsearch.Visible = false;
            txtsearch.Visible = false;
            btnlateprocessing.Left = 416;
            btnlateprocessing.Size = new System.Drawing.Size(149, 32);
            btnupcomingprocess.Size = new System.Drawing.Size(149, 32);
            btnupcomingprocess.Left = 566;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            btnsearch.Visible = false;
            txtsearch.Text = "";
            pctrsearch.Visible = true;
            txtsearch.Visible = true;
            btnlateprocessing.Left = 443;
            btnlateprocessing.Size = new System.Drawing.Size(136, 32);
            btnupcomingprocess.Size = new System.Drawing.Size(136, 32);
            btnupcomingprocess.Left = 580;
        }

        private void pctrsearch_Click(object sender, EventArgs e)
        {
            btnsearch.Visible = true;
            pctrsearch.Visible = false;
            txtsearch.Visible = false;
            btnlateprocessing.Left = 416;
            btnlateprocessing.Size = new System.Drawing.Size(149, 32);
            btnupcomingprocess.Size = new System.Drawing.Size(149, 32);
            btnupcomingprocess.Left = 566;
            ListSearch(txtsearch.Text);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string student = dgwlist.CurrentRow.Cells["AD SOYAD"].Value.ToString().ToLower().Trim();
            string book = dgwlist.CurrentRow.Cells["KİTAP ADI"].Value.ToString().ToLower().Trim();
            string status = dgwlist.CurrentRow.Cells["DURUMU"].Value.ToString().ToLower().Trim();
            int proccesid = Convert.ToInt32(dgwlist.CurrentRow.Cells["İŞLEM NO"].Value);
            DateTime purhasedate = Convert.ToDateTime(dgwlist.CurrentRow.Cells["Alış Tarihi"].Value);
            DateTime issuedate = Convert.ToDateTime(dgwlist.CurrentRow.Cells["Veriş Tarihi"].Value);
            string note = dgwlist.CurrentRow.Cells["NOT"].Value.ToString().ToLower().Trim();
            if (proccesManager.registeredStudent(student) != student)
            {
                MessageBox.Show(student + " Adlı öğrenci sistemde bulunmuyor\n\nÖnce " + student + " Adlı öğrenciyi öğrenci tablomuza eklemeniz gerekmektedir", "Mevcut olmayan öğrenci ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (proccesManager.registeredBook(book) != book)
            {
                MessageBox.Show(book + " Adlı kitap sistemde bulunmuyor\n\nÖnce " + book + " Adlı kitabı kitap tablomuza eklemeniz gerekmektedir", "Mevcut olmayan kitap ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((status != "getirdi") && (status != "getirmedi") && status != "")
            {
                MessageBox.Show(status + " Geçersiz ifade \n\n'getirdi' veya 'getirmedi' olarak değiştirin", "Yanlış söz dizimi ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dg = MessageBox.Show(proccesid + " Numaralı işlem Güncellensin mi?", "GÜNCELLE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if (dg == DialogResult.Yes)
                {
                    Procces procces = new Procces
                    {
                        ProccesId = proccesid,
                        StudentId = proccesManager.registeredStudentId(student),
                        BookId =Convert.ToInt32( proccesManager.registeredBookId(book)),
                        PurhaseDate = purhasedate,
                        IssueDate = issuedate,
                        Status = status,
                        Note = note
                    };
                    proccesManager.Update(procces);
                    ListBase();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int proccesid = Convert.ToInt32(dgwlist.CurrentRow.Cells["İŞLEM NO"].Value);
            string student = dgwlist.CurrentRow.Cells["AD SOYAD"].Value.ToString();
            DialogResult dg = MessageBox.Show(proccesid + " Numaralı " + student + " Adlı kişinin işemi silinsin mi?", "SİL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                proccesManager.Delete(new Procces
                {
                    ProccesId = proccesid
                });
                ListBase();
            }
        }

        private void btnlateprocessing_Click(object sender, EventArgs e)
        {
            ListLateProccessing();
        }

        private void btnupcomingprocess_Click(object sender, EventArgs e)
        {
            ListUpComingProcess();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            
            if (txtstudent.Text == "" || txtbook.Text == "")
            {
                lblerror.Text = "Lütfen Öğrenci adı ve kitap giriniz";
            }
            else
            {

                lblerror.Text = null;
                if (proccesManager.registeredStudent(txtstudent.Text) != txtstudent.Text.ToLower().Trim())
                {
                    MessageBox.Show(txtstudent.Text + " Adlı öğrenci sistemde bulunmuyor\n\nÖnce " + txtstudent.Text + " Adlı öğrenciyi öğrenci tablomuza eklemeniz gerekmektedir", "Mevcut olmayan tür ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (proccesManager.registeredBook(txtbook.Text) != txtbook.Text.ToLower().Trim())
                {
                    MessageBox.Show(txtbook.Text + " Adlı kitap sistemde bulunmuyor\n\nÖnce " + txtbook.Text + " Adlı kitabı kitap tablomuza eklemeniz gerekmektedir", "Mevcut olmayan yazar ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Procces user = new Procces {
                        StudentId = proccesManager.registeredStudentId(txtstudent.Text),
                        BookId =Convert.ToInt32( proccesManager.registeredBookId(txtbook.Text)),
                        PurhaseDate =Convert.ToDateTime( dtpurhasedate.Text),
                        IssueDate=Convert.ToDateTime(dtissuedate.Text),
                        Note=txtnote.Text
                    };
                    proccesManager.Add(user); 
                    ListBase();
                    TextboxClear();
                }
            }
            dgvbooks.Visible = false;
            dgvstudent.Visible = false;
        }
        public void TextboxClear()
        {
            txtstudent.Text = "";
            txtbook.Text = "";
            txtnote.Text = "";
        }

        private void txtbook_TextChanged(object sender, EventArgs e)
        {
            dgvstudent.Visible = false;
            dgvbooks.Visible = true;
            proccesManager.HandleException(() =>
            {
                string query = "SELECT BookName 'KİTAP ADI' " +
                            "FROM Books " +
                            "WHERE BookName LIKE '%" + txtbook.Text + "%'";
                using (SqlCommand command = new SqlCommand(query, proccesManager.Connection()))
                {
                    proccesManager.ConnectionOpenControl();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            dgvbooks.DataSource = dataTable;
                        }
                    }
                }
            });
        }

        private void dgvbooks_Click(object sender, EventArgs e)
        {
            txtbook.Text = dgvbooks.CurrentRow.Cells["KİTAP ADI"].Value.ToString();
            dgvbooks.Visible = false;
            dgvstudent.Visible = false;
        }

        private void txtstudent_TextChanged(object sender, EventArgs e)
        {
            dgvstudent.Visible = true;
            dgvbooks.Visible = false;
            proccesManager.HandleException(() =>
            {
                string query = "SELECT StudentName+' '+StudentSurname 'ÖĞRENCİ' " +
                            "FROM Students " +
                            "WHERE StudentName+' '+StudentSurname LIKE '%" + txtstudent.Text + "%'";
                using (SqlCommand command = new SqlCommand(query, proccesManager.Connection()))
                {
                    proccesManager.ConnectionOpenControl();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            dgvstudent.DataSource = dataTable;
                        }
                    }
                }
            });
        }

        private void dgvstudent_Click(object sender, EventArgs e)
        {
            txtstudent.Text = dgvstudent.CurrentRow.Cells["ÖĞRENCİ"].Value.ToString();
            dgvstudent.Visible = false;
            dgvbooks.Visible = false;
        }

        private void tabproccesadd_Click(object sender, EventArgs e)
        {
            dgvbooks.Visible = false;
            dgvstudent.Visible = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dgvstudent.Visible = false;
            dgvbooks.Visible = false;
        }

        private void dgwlist_Click(object sender, EventArgs e)
        {
            dgvstudent.Visible = false;
            dgvbooks.Visible = false;
        }
    }
}
