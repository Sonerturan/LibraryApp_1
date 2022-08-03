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
    public partial class PageSignIn : Form
    {
        UserManager userDal = new UserManager();
        public PageSignIn()
        {
            InitializeComponent();
        }
        public void textboxclear()
        {
            txtname.Text = "";
            txtsurname.Text = "";
            txtemail.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            txtpasswordconfrim.Text = "";
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtpasswordconfrim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            User user = new User() {
                Username = txtusername.Text,
                Password = txtpassword.Text,
                Name = txtname.Text,
                Surname = txtsurname.Text,
                Email = txtemail.Text
            };
            if (user.Username == "" || user.Password == "" || user.Name == "" || user.Surname == "" || user.Email == "" || txtpasswordconfrim.ToString() == "")
            {
                lblerror.Text = "Lütfen boş alan bırakmayınız";
            }
            else if (user.Password.ToString() != txtpasswordconfrim.Text)
            {
                lblerror.Text = "Girdiğiniz şifreler uyuşmuyor";
            }
            else if (user.Password.Length < 4)
            {
                lblerror.Text = "Şifreniz en az 4 karakter olmalıdır !";
            }
            else if (userDal.registeredUserName(txtusername.Text) == txtusername.Text.ToLower().Trim())
            {
                MessageBox.Show(txtusername.Text + " ad'lı kullanıcı  sistemde Zaten mevcut", "Mevcut olan kullanıcı ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userDal.Add(new User
                {
                    Username = user.Username,
                    Password = user.Password,
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email
                });
            }
            textboxclear();
        }

        private void PageSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
