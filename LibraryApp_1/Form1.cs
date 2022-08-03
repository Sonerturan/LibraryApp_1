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
    public partial class Form1 : Form
    {

        PageLogIn pageLogin = new PageLogIn();
        PageSignIn pageSignin = new PageSignIn();
        Form2 form2 = new Form2();
        int Moves;
        int Mouse_X;
        int Mouse_Y;
        int sayac1 = 0;
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pageLogin.MdiParent = this;
            panelright.Controls.Add(pageLogin);
            pageLogin.Show();
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

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbtransformation_Click(object sender, EventArgs e)
        {
            if (sayac1 % 2 == 0)
            {
                pageSignin.textboxclear();
                pageLogin.Hide();
                pageSignin.MdiParent = this;
                panelright.Controls.Add(pageSignin);
                pageSignin.Show();
                lbtransformation.Top = 538;
                lbtransformation.Text = "Zaten Hesabın Var mı ? Giriş Yap...";
                pageSignin.lblerror.Text = "";
                btnlogin.Visible = false;
                sayac1 = sayac1 + 1;
            }
            else
            {
                pageSignin.Hide();
                pageLogin.MdiParent = this;
                btnlogin.Visible = true;
                panelright.Controls.Add(pageLogin);
                pageLogin.Show();
                lbtransformation.Top = 346;
                lbtransformation.Text = "Hesabın Yok mu ? Hemen Oluştur...";
                sayac1 = sayac1 + 1;
            }
        }

        private void btnmore_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                btnmore.Text = "Daha Az";
                btnmore.Top = 500;
                sayac = sayac + 1;
                lblcontent.Text = "Lorem Ipsum is simply dummy text of the printing and \n" +
                    " typesetting industry. Lorem Ipsum has been the \n" +
                    " industry's standard dummy text ever since the 1500s,\n" +
                     "when an unknown printer took a galley of type and \n" +
                     "scrambled it to make a type specimen book. It has \n" +
                     "survived not only five centuries, but also the leap \n" +
                     "into electronic typesetting, remaining essentially \n" +
                     "unchanged. It was popularised in the 1960s with the \n" +
                     "release of Letraset sheets containing Lorem Ipsum \n" +
                     "passages, and more recently with desktop publishing ";
            }
            else
            {
                btnmore.Text = "Daha Fazla";
                btnmore.Top = 412;
                sayac = sayac + 1;
                lblcontent.Text = "Lorem Ipsum is simply dummy text of the printing and \n" +
                    " typesetting industry. Lorem Ipsum has been the \n" +
                    " industry's standard dummy text ever since the 1500s,\n" +
                     "when an unknown...";
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            int _loginValidatorControl = pageLogin.Login();
            string _username = pageLogin.Username();

            if (_loginValidatorControl != -1)
            {
                this.Hide();
                form2.lblusername.Text = _username;
                form2.Show();
            }
        }
    }
}
