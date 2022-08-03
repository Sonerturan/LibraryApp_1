using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp_1
{
    class UserManager : BaseEntityDal,ICrudManager<User>
    {
        public string errorMessage = "";
        public int loginValidatorControl = -1;
        public string _username = "";
        public int LoginValidator(User entity)
        {
            string query = "Select * From [dbo].[Users] Where Username = '" + entity.Username.Trim().ToLower() + "'and Password = '" + entity.Password.Trim().ToLower() + "'";
            string readered = "UserName";
            string readered2 = "Password";
            if (RegisteredControl(query, readered, readered2)!=" ")
            {
                loginValidatorControl = 0;
                _username = entity.Username;
            }
            else
            {
                loginValidatorControl = -1; 
                MessageBox.Show("Yanlış şifre veya kullanıcı adı girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            return loginValidatorControl;
        }
        public string registeredUserName(string username)
        {
            string query = "SELECT * FROM Users WHERE UserName='" + username + "'";
            string readered = "UserName";
            return RegisteredControl(query, readered);
        }
        public void Add(User entity)
        {
            string query = "INSERT INTO Users(Username,Password,Name,Surname,Email) " +
                            "VALUES('" + entity.Username.Trim().ToLower() + "','" + entity.Password.Trim().ToLower() + "','" + entity.Name.Trim().ToLower() + "','" + entity.Surname.Trim().ToLower() + "','" + entity.Email.Trim().ToLower() + "')";
            EntityAdd(query);
        }
        public void Update(User entity)
        {
            string query = "UPDATE Users SET Password = '" + entity.Password + "' , Name = '" + entity.Name + "', Surname = '" + entity.Surname + "' , Email = '" + entity.Email + "' WHERE Username = '" + entity.Username + "' ";
            EntityUpdate(query);
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListBase()
        {
            throw new NotImplementedException();
        }

        public DataTable ListSearch(string searchcontent)
        {
            throw new NotImplementedException();
        }
    }
}
