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
    class DBLibraryContext
    {
        SqlConnection _connection;

        public SqlConnection Connection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "sonerturan.database.windows.net";
            builder.UserID = "DB_Repository";
            builder.Password = "Turansoner2506";
            builder.InitialCatalog = "DBLibrary";
            _connection = new SqlConnection(builder.ConnectionString);
            return _connection;
        }
        public void ConnectionOpenControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void ConnectionCloseControl()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }
        public void ConnectionRefresh()
        {
            ConnectionCloseControl();
            ConnectionOpenControl();
        }
        
        public void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                ConnectionCloseControl();
            }
        }
    }
}
