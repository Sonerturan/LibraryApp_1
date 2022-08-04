using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_1
{
    class BookManager : BaseEntityDal, ICrudManager<Book>
    {
        public void Add(Book entity)
        {
            string query = "INSERT INTO Books(BookName,YearOfPublication,PageNumber,WriterId,TypeId,PublisherId) " +
                            "VALUES('" + entity.BookName + "',SUBSTRING('" + entity.YearOfPublication + "',4,3)+SUBSTRING('" + entity.YearOfPublication + "',1,3)+SUBSTRING('" + entity.YearOfPublication + "',7,4),'" + entity.PageNumber + "','" + entity.WriterId + "','" + entity.TypeId + "','" + entity.PublisherId + "')";

            EntityAdd(query);
        }

        public void Delete(Book entity)
        {
            string query = "DELETE FROM Books WHERE BookId='" + entity.BookId + "'";
            EntityDelete(query);
        }

        public DataTable ListBase()
        {
            string query = "Select b.BookId AS'KİTAP NO',b.BookName 'KİTAP ADI',b.YearOfPublication 'BASIM YILI',b.PageNumber 'Sayfa Sayısı',w.WriterName + ' ' + WriterSurname 'YAZAR',t.TypeName 'TÜR',p.PublisherName 'YAYINEVİ' From Books b LEFT JOIN Writers w ON b.WriterId = w.WriterId LEFT JOIN Publishers p ON b.PublisherId = p.PublisherId LEFT JOIN Types t ON b.TypeId = t.TypeId ";

            return EntityList(query);
        }

        public DataTable ListSearch(string searchcontent)
        {
            string query = "Select b.BookId AS'KİTAP NO',b.BookName 'KİTAP ADI',b.YearOfPublication 'BASIM YILI',b.PageNumber 'Sayfa Sayısı',w.WriterName + ' ' + WriterSurname 'YAZAR',t.TypeName 'TÜR',p.PublisherName 'YAYINEVİ' From Books b LEFT JOIN Writers w ON b.WriterId = w.WriterId LEFT JOIN Publishers p ON b.PublisherId = p.PublisherId LEFT JOIN Types t ON b.TypeId = t.TypeId WHERE b.BookName LIKE '%" + searchcontent + "%'";

            return EntityList(query);
        }
        public DataTable ListSearchWriter(string searchcontent)
        {
            string query = "Select b.BookId AS'KİTAP NO',b.BookName 'KİTAP ADI',b.YearOfPublication 'BASIM YILI',b.PageNumber 'Sayfa Sayısı',w.WriterName + ' ' + WriterSurname 'YAZAR',t.TypeName 'TÜR',p.PublisherName 'YAYINEVİ' From Books b LEFT JOIN Writers w ON b.WriterId = w.WriterId LEFT JOIN Publishers p ON b.PublisherId = p.PublisherId LEFT JOIN Types t ON b.TypeId = t.TypeId WHERE w.WriterName+' '+w.WriterSurname LIKE '%" + searchcontent + "%'";

            return EntityList(query);
        }
        public DataTable ListSearchType(string searchcontent)
        {
            string query = "Select b.BookId AS'KİTAP NO',b.BookName 'KİTAP ADI',b.YearOfPublication 'BASIM YILI',b.PageNumber 'Sayfa Sayısı',w.WriterName + ' ' + WriterSurname 'YAZAR',t.TypeName 'TÜR',p.PublisherName 'YAYINEVİ' From Books b LEFT JOIN Writers w ON b.WriterId = w.WriterId LEFT JOIN Publishers p ON b.PublisherId = p.PublisherId LEFT JOIN Types t ON b.TypeId = t.TypeId WHERE t.TypeName LIKE '%" + searchcontent + "%'";

            return EntityList(query);
        }
        public DataTable ListSearchPublisher(string searchcontent)
        {
            string query = "Select b.BookId AS'KİTAP NO',b.BookName 'KİTAP ADI',b.YearOfPublication 'BASIM YILI',b.PageNumber 'Sayfa Sayısı',w.WriterName + ' ' + WriterSurname 'YAZAR',t.TypeName 'TÜR',p.PublisherName 'YAYINEVİ' From Books b LEFT JOIN Writers w ON b.WriterId = w.WriterId LEFT JOIN Publishers p ON b.PublisherId = p.PublisherId LEFT JOIN Types t ON b.TypeId = t.TypeId WHERE t.TypeName LIKE '%" + searchcontent + "%'";

            return EntityList(query);
        }

        public void Update(Book entity)
        {
            string query = "UPDATE Books SET BookName='" + entity.BookName + "',YearOfPublication=SUBSTRING('" + entity.YearOfPublication + "',4,3)+SUBSTRING('" + entity.YearOfPublication + "',1,3)+SUBSTRING('" + entity.YearOfPublication + "',7,4),PageNumber='" + entity.PageNumber + "',WriterId='" + entity.WriterId + "',TypeId='" + entity.TypeId + "',PublisherId='" + entity.PublisherId + "' WHERE BookId='" + entity.BookId + "'";
            EntityUpdate(query);
        }


        public string registeredWriterId(string writer)
        {
            string query = "SELECT * FROM Writers WHERE WriterName+' '+WriterSurname='" + writer + "'";
            string readered = "WriterId";
            return RegisteredControl(query, readered);
        }
        public string registeredWriter(string writer)
        {
            string query = "SELECT * FROM Writers WHERE WriterName+' '+WriterSurname='" + writer + "'";
            string readered = "WriterName";
            string readered2 = "WriterSurname";
            return RegisteredControl(query, readered, readered2);
        }
        public string registeredTypeId(string type)
        {
            string query = "SELECT * FROM Types WHERE TypeName='" + type + "'";
            string readered = "TypeId";
            return RegisteredControl(query, readered);

        }
        public string registeredType(string type)
        {
            string query = "SELECT * FROM Types WHERE TypeName='" + type + "'";
            string readered = "TypeName";
            return RegisteredControl(query, readered);
        }
        public string registeredPublisherId(string publisher)
        {
            string query = "SELECT * FROM Publishers WHERE PublisherName='" + publisher + "'";
            string readered = "PublisherId";
            return RegisteredControl(query, readered);

        }
        public string registeredPublisher(string publisher)
        {
            string query = "SELECT * FROM Publishers WHERE PublisherName='" + publisher + "'";
            string readered = "PublisherName";
            return RegisteredControl(query, readered);
        }
    }
}
