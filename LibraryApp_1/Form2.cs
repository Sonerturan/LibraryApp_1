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
    public partial class Form2 : Form
    {
        PageProccess pageProccess = new PageProccess();
        PageUserInformation pageUserInformation = new PageUserInformation();
        UserManager userDal = new UserManager();
        PageStudents pageStudents = new PageStudents();
        PageBooks pageBooks = new PageBooks();
        PageWriters pageWriters = new PageWriters();
        PagePublishers pagePublishers = new PagePublishers();
        PageTypes pageTypes = new PageTypes();
        int Moves;
        int Mouse_X;
        int Mouse_Y;
        public int sayac = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void paneltop_MouseUp(object sender, MouseEventArgs e)
        {
            Moves = 0;
        }

        private void paneltop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Moves == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            Moves = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pageProccess.MdiParent = this;
            panelcontent.Controls.Add(pageProccess);
            pageProccess.Show();
        }

        private void pctrlogo_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                pageUserInformation.MdiParent = this;
                panelleft.Controls.Add(pageUserInformation);
                pageUserInformation.Show();
                pctrlogo.Visible = false;
                pctrlogo2.Visible = true;
                pctrlogout.Visible = true;
                pctrlogo2.BackColor = Color.MediumAquamarine;
                lblusername.BackColor = Color.MediumAquamarine;
                lbllogout.Visible = true;
                lbllogout.BackColor = Color.MediumAquamarine;
                pageUserInformation.txtpasswordconfrim.Visible = false;
                pageUserInformation.btnsave.Visible = false;
                panelleft.Visible = true;
                panel5.BackColor = Color.MediumAquamarine;
                sayac++;


                string query = "Select * From Users Where Username = '" + lblusername.Text + "'";
                using (SqlCommand command = new SqlCommand(query, userDal.Connection()))
                {
                    userDal.ConnectionOpenControl();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pageUserInformation.lblusername.Text = reader["Username"].ToString();
                            pageUserInformation.txtname.Text = reader["Name"].ToString();
                            pageUserInformation.txtsurname.Text = reader["Surname"].ToString();
                            pageUserInformation.txtemail.Text = reader["Email"].ToString();
                            pageUserInformation.txtpassword.Text = reader["Password"].ToString();
                            pageUserInformation.txtpasswordconfrim.Text = reader["Password"].ToString();
                        }
                    }
                }



            }
            else
            {
                pageUserInformation.Hide();
                pctrlogo.Visible = true;
                pctrlogo2.Visible = false;
                lblusername.BackColor = Color.White;
                lbllogout.Visible = false;
                pctrlogout.Visible = false;
                pageUserInformation.txtname.BorderStyle = BorderStyle.None;
                pageUserInformation.txtsurname.BorderStyle = BorderStyle.None;
                pageUserInformation.txtemail.BorderStyle = BorderStyle.None;
                pageUserInformation.txtpassword.BorderStyle = BorderStyle.None;
                panelleft.Visible = false;
                panel5.BackColor = Color.White;
                sayac++;
            }
        }


        private void lbllogout_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Çıkış yapmak istiyor musunuz !", "ÇIKIŞ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }

        private void btnprocces_Click(object sender, EventArgs e)
        {
            pageWriters.Hide();
            pageBooks.Hide();
            pageTypes.Hide();
            pagePublishers.Hide();
            pageStudents.Hide();
            pageProccess.MdiParent = this;
            panelcontent.Controls.Add(pageProccess);
            pageProccess.Show();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            pageWriters.Hide();
            pageBooks.Hide();
            pageTypes.Hide();
            pagePublishers.Hide();
            pageProccess.Hide();
            pageStudents.MdiParent = this;
            panelcontent.Controls.Add(pageStudents);
            pageStudents.Show();
        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            pageWriters.Hide();
            pageProccess.Hide();
            pageTypes.Hide();
            pagePublishers.Hide();
            pageStudents.Hide();
            pageBooks.MdiParent = this;
            panelcontent.Controls.Add(pageBooks);
            pageBooks.Show();
        }

        private void btnwriters_Click(object sender, EventArgs e)
        {
            pageBooks.Hide();
            pageProccess.Hide();
            pageTypes.Hide();
            pagePublishers.Hide();
            pageStudents.Hide();
            pageWriters.MdiParent = this;
            panelcontent.Controls.Add(pageWriters);
            pageWriters.Show();
        }

        private void btntypes_Click(object sender, EventArgs e)
        {
            pageBooks.Hide();
            pageProccess.Hide();
            pageWriters.Hide();
            pagePublishers.Hide();
            pageStudents.Hide();
            pageTypes.MdiParent = this;
            panelcontent.Controls.Add(pageTypes);
            pageTypes.Show();
        }

        private void btnpublisher_Click(object sender, EventArgs e)
        {
            pageBooks.Hide();
            pageProccess.Hide();
            pageWriters.Hide();
            pageTypes.Hide();
            pageStudents.Hide();
            pagePublishers.MdiParent = this;
            panelcontent.Controls.Add(pagePublishers);
            pagePublishers.Show();
        }
    }
}
