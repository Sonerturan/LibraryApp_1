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
    class PublisherManager : BaseEntityDal,ICrudManager<Publisher>
    {
        public void Add(Publisher entity)
        {
            string query = "INSERT INTO Publishers(PublisherName,PublisherPhone,PublisherAdress) " +
                            "VALUES('" + entity.PublisherName + "','" + entity.PublisherPhone + "','" + entity.PublisherAdress + "')";
            EntityAdd(query);
        }

        public void Delete(Publisher entity)
        {
            string query = "DELETE FROM Publishers WHERE PublisherId=" + entity.PublisherId + ""; 
            EntityDelete(query);
        }
        public string RegisteredPublisherName(string publishername)
        {
            string query = "SELECT * FROM Publishers WHERE PublisherName='" + publishername + "'";
            string readered = "PublisherName";
            return RegisteredControl(query,readered);
        }

        public void Update(Publisher entity)
        {
            string query = "UPDATE Publishers SET PublisherName='" + entity.PublisherName + "',PublisherPhone='" + entity.PublisherPhone + "',PublisherAdress='" + entity.PublisherAdress + "' WHERE PublisherId='" + entity.PublisherId + "'";
            EntityUpdate(query);
        }
        public DataTable ListBase()
        {
            string query = "Select Publishers.PublisherId'YAYINEVİ NO',Publishers.PublisherName 'YAYINEVİ AD',Publishers.PublisherPhone 'YAYINEVİ TEL',Publishers.PublisherAdress 'YAYINEVİ ADRES',COUNT(Books.PublisherId)'Kayıtlı Kitap Adedi' FROM Publishers LEFT JOIN Books ON Publishers.PublisherId=Books.PublisherId GROUP BY Publishers.PublisherId,Publishers.PublisherName,Publishers.PublisherPhone,Publishers.PublisherAdress";

            return EntityList(query);
        }
        public DataTable ListSearch(string searchcontent)
        {
            string query = "Select Publishers.PublisherId'YAYINEVİ NO',Publishers.PublisherName 'YAYINEVİ AD',Publishers.PublisherPhone 'YAYINEVİ TEL',Publishers.PublisherAdress 'YAYINEVİ ADRES',COUNT(Books.PublisherId)'Kayıtlı Kitap Adedi' FROM Publishers LEFT JOIN Books ON Publishers.PublisherId=Books.PublisherId GROUP BY Publishers.PublisherId,Publishers.PublisherName,Publishers.PublisherPhone,Publishers.PublisherAdress" +
                 " HAVING PublisherName LIKE '%" + searchcontent.Trim().ToLower() + "%'";

            return EntityList(query);
        }

    }
}
