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
    public partial class PageUserInformation : Form
    {
        UserManager userDal = new UserManager();
        public PageUserInformation()
        {
            InitializeComponent();
        }

        private void pctreyes_Click(object sender, EventArgs e)
        {

        }

        private void txtpasswordconfrim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pctrname_Click(object sender, EventArgs e)
        {
            txtname.BorderStyle = BorderStyle.FixedSingle;
            btnsave.Visible = true;
        }

        private void pctrsurname_Click(object sender, EventArgs e)
        {
            txtsurname.BorderStyle = BorderStyle.FixedSingle;
            btnsave.Visible = true;
        }

        private void pctremail_Click(object sender, EventArgs e)
        {
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            btnsave.Visible = true;
        }

        private void pctrpassword_Click(object sender, EventArgs e)
        {
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            btnsave.Visible = true;
            txtpasswordconfrim.Visible = true;
            pxtreyes.Visible = true;
        }

        private void pxtreyes_Click(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
            txtpasswordconfrim.PasswordChar = '*';
        }

        private void pxtreyes_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '\0';
            txtpasswordconfrim.PasswordChar = '\0';
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = lblusername.Text,
                Password = txtpassword.Text,
                Name = txtname.Text,
                Surname = txtsurname.Text,
                Email = txtemail.Text
            };
            if (user.Username == "" || user.Password == "" || user.Name == "" || user.Surname == "" || user.Email == "" || txtpasswordconfrim.ToString() == "")
            {
                MessageBox.Show( "Lütfen boş alan bırakmayınız");
            }
            else if (user.Password.ToString() != txtpasswordconfrim.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor");
            }
            else if (user.Password.Length < 4)
            {
                MessageBox.Show("Şifreniz en az 4 karakter olmalıdır !");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Hesabınızda Yaptığınız Değişiklikleri Kaydetmek İstiyor musunuz", "HESABIMI GÜNCELLE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (dg == DialogResult.Yes)
                {
                    userDal.Update(new User
                    {
                        Username = user.Username,
                        Password = user.Password,
                        Name = user.Name,
                        Surname = user.Surname,
                        Email = user.Email
                    });
                }
            }
            
        }
    }
}
