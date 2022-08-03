using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp_1
{
    public partial class PageLogIn : Form
    {

        UserManager userManager = new UserManager();
        public PageLogIn()
        {
            InitializeComponent();
        }



        //parolayı göster
        private void pctreyes_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '\0';
        }
        //parolayı gizle
        private void pctreyes_Click(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }
        //textbox için
        private void txtusername_Click(object sender, EventArgs e)
        {
            txtusername.Text = null;
        }
        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.Text = null;
            txtpassword.PasswordChar = '*';
        }
        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }
        //txtpassword sadece sayısal değer içerebilir
        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public int Login()
        {
            userManager.LoginValidator(new User
            {
                Username = txtusername.Text,
                Password = txtpassword.Text
            });
            return userManager.loginValidatorControl;
        }
        public string Username()
        {
            return userManager._username;
        }
    }
}
