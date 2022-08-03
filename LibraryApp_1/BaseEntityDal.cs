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
    class BaseEntityDal : DBLibraryContext
    {
        public void HandleExceptionControl(Action action)
        {
            HandleException(() =>
            {
                //action.Invoke();
            });
        }
        public void EntityAdd(string query)
        {
            using (SqlCommand command = new SqlCommand(query, Connection()))
            {
                ConnectionOpenControl();
                command.ExecuteNonQuery();
                MessageBox.Show("İşlem başarıyla eklendi.", "Kayıt işlemi başarılı ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HandleExceptionControl(() => { this.EntityAdd(query); });
            }
            HandleExceptionControl(() => { this.EntityAdd(query); });
        }

        public void EntityDelete(string query)
        {
            using (SqlCommand command = new SqlCommand(query, Connection()))
            {
                ConnectionOpenControl();
                command.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti", "SİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HandleExceptionControl(() => { this.EntityDelete(query); });
        }

        public DataTable EntityList(string query)
        {
            DataTable dataTable = null;
            using (SqlCommand command = new SqlCommand(query, Connection()))
            {
                ConnectionOpenControl();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    using (dataTable = new DataTable())
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            HandleExceptionControl(() => { this.EntityList(query); });
            return dataTable;
        }

        public void EntityUpdate(string query)
        {
            using (SqlCommand command = new SqlCommand(query, Connection()))
            {
                ConnectionOpenControl();
                command.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti\n(Güncelleme işlemi yalnızca bir satırda uygulanır)", "GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            HandleExceptionControl(() => { this.EntityUpdate(query); });
        }

        public string RegisteredControl(string query, string readered)
        {
            string _registeredobject = "";
            using (SqlCommand command = new SqlCommand(query, Connection()))
            {
                ConnectionOpenControl();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        _registeredobject = reader[readered].ToString();
                    }
                }
            }
            HandleExceptionControl(() => { this.RegisteredControl(query, readered); });
            return (_registeredobject);
        }
        //İşlem katmanındaki öğrenci ad soyad işlemi için doğrulayıcı
        //login işlemi için username password validator
        public string RegisteredControl(string query, string readered, string readered2)
        {
            string _registeredobject = "";
            string _registeredobject2 = "";
            using (SqlCommand command = new SqlCommand(query, Connection()))
            {
                ConnectionOpenControl();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        _registeredobject = reader[readered].ToString();
                        _registeredobject2 = reader[readered2].ToString();
                    }
                }
            }
            HandleExceptionControl(() => { this.RegisteredControl(query, readered, readered2); });
            return (_registeredobject.ToString() + " " + _registeredobject2.ToString()); 
        }
    }
}
