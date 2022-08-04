using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_1
{
    class WriterManager : BaseEntityDal, ICrudManager<Writer>
    {
        public void Add(Writer entity)
        {
            string query = "INSERT INTO Writers(WriterName,WriterSurname) " +
                               "VALUES('" + entity.WriterName + "','" + entity.WriterSurname + "')";
            EntityAdd(query);
        }
        public string RegisteredWriter(string writer)
        {
            string query = "SELECT * FROM Writers WHERE WriterName+' '+WriterSurname='" + writer + "'";
            string readered = "WriterName";
            string readered2 = "WriterSurname";
            return RegisteredControl(query, readered,readered2);
        }
        public void Delete(Writer entity)
        {
            string query = "DELETE FROM Writers WHERE TypeId='" + entity.WriterId + "'";
            EntityDelete(query);
        }

        public DataTable ListBase()
        {
            string query = "Select WriterId 'Yazar No',WriterName'Yazar Ad',WriterSurname 'Yazar Soyad' FROM Writers";

            return EntityList(query);
        }

        public DataTable ListSearch(string searchcontent)
        {
            string query = "Select WriterId 'Yazar No',WriterName'Yazar Ad',WriterSurname 'Yazar Soyad' FROM Writers " +
                "WHERE WriterName LIKE '%"+searchcontent.ToLower().Trim()+"%' OR WriterSurname LIKE '%" + searchcontent.ToLower().Trim() + "%' OR WriterName+' '+WriterSurname LIKE '%" + searchcontent.ToLower().Trim() + "%'";

            return EntityList(query);
        }

        public void Update(Writer entity)
        {
            string query = "UPDATE Writers SET WriterName='" + entity.WriterName + "',WriterSurname='" + entity.WriterSurname + "' WHERE WriterId='" + entity.WriterId + "'";
            EntityUpdate(query);
        }
    }
}
