using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_1
{
    class TypeManager : BaseEntityDal, ICrudManager<Type>
    {
        public void Add(Type entity)
        {
            string query = "INSERT INTO Types(TypeName) " +
                               "VALUES('" + entity.TypeName+ "')";
            EntityAdd(query);
        }
        public string RegisteredTypeName(string typename)
        {
            string query = "SELECT * FROM Types WHERE TypeName='" + typename + "'";
            string readered = "TypeName";
            return RegisteredControl(query, readered);
        }
        public void Delete(Type entity)
        {
            string query = "DELETE FROM Types WHERE TypeId='" + entity.TypeId + "'";
            EntityDelete(query);
        }

        public DataTable ListBase()
        {
            string query = "Select Types.TypeId 'TÜR NO',Types.TypeName 'TÜR AD',COUNT(Books.TypeId) 'Kayıtlı Kitap Adedi' FROM Types  LEFT JOIN Books ON Types.TypeId=Books.TypeId GROUP BY Types.TypeName,Types.TypeId";

            return EntityList(query);
        }

        public DataTable ListSearch(string searchcontent)
        {
            string query = "Select Types.TypeId 'TÜR NO',Types.TypeName 'TÜR AD',COUNT(Books.TypeId) 'Kayıtlı Kitap Adedi' FROM Types  LEFT JOIN Books ON Types.TypeId=Books.TypeId GROUP BY Types.TypeName,Types.TypeId"+
                 " HAVING TypeName LIKE '%" + searchcontent.Trim().ToLower() + "%'";

            return EntityList(query);
        }

            public void Update(Type entity)
        {
            string query = "UPDATE Types SET TypeName='" + entity.TypeName + "' WHERE TypeId='" + entity.TypeId + "'";
            EntityUpdate(query);
        }
    }
}
