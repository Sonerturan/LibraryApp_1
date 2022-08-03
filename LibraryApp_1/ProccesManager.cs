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
    class ProccesManager : BaseEntityDal, ICrudManager<Procces>
    {
        public void Add(Procces entity)
        {
            string query = "INSERT INTO Proccess(StudentId,BookId,PurhaseDate,IssueDate,Status,Note) " +
                            "VALUES('" + entity.StudentId + "','" + entity.BookId + "',SUBSTRING('" + entity.PurhaseDate + "',4,3)+SUBSTRING('" + entity.PurhaseDate + "',1,3)+SUBSTRING('" + entity.PurhaseDate + "',7,4),SUBSTRING('" + entity.IssueDate + "',4,3)+SUBSTRING('" + entity.IssueDate + "',1,3)+SUBSTRING('" + entity.IssueDate + "',7,4),'" + entity.Status + "','" + entity.Note + "')";

            EntityAdd(query);
        }

        public void Delete(Procces entity)
        {
            string query = "DELETE FROM Proccess WHERE ProccesId='" + entity.ProccesId + "'";
            EntityDelete(query);
        }


        public string registeredStudentId(string student)
        {
            string query = "SELECT * FROM Students WHERE StudentName+' '+StudentSurname='" + student + "'";
            string readered = "StudentId";
            return RegisteredControl(query, readered);
        }
        public string registeredStudent(string student)
        {
            string query = "SELECT * FROM Students WHERE StudentName+' '+StudentSurname='" + student + "'";
            string readered = "StudentName";
            string readered2 = "StudentSurname";
            return RegisteredControl(query, readered,readered2);
        }
        public string registeredBookId(string book)
        {
            string query = "SELECT * FROM Books WHERE BookName='" + book + "'";
            string readered = "BookId";
            return RegisteredControl(query, readered);
            
        }
        public string registeredBook(string book)
        {
            string query = "SELECT * FROM Books WHERE BookName='" + book + "'";
            string readered = "BookName";
            return RegisteredControl(query, readered);
        }
        public void Update(Procces entity)
        {
            string query = "UPDATE Proccess SET StudentId='" + entity.StudentId + "',BookId='" + entity.BookId + "',PurhaseDate=SUBSTRING('" + entity.PurhaseDate + "',4,3)+SUBSTRING('" + entity.PurhaseDate + "',1,3)+SUBSTRING('" + entity.PurhaseDate + "',7,4),IssueDate=SUBSTRING('" + entity.IssueDate + "',4,3)+SUBSTRING('" + entity.IssueDate + "',1,3)+SUBSTRING('" + entity.IssueDate + "',7,4),Status='" + entity.Status + "',Note='" + entity.Note + "' WHERE ProccesId='" + entity.ProccesId + "'";
            EntityUpdate(query);
        }
        public DataTable ListBase()
        {
            string query = "SELECT p.ProccesId 'İŞLEM NO',s.StudentName +' '+ s.StudentSurname'AD SOYAD',b.BookName'KİTAP ADI' ,p.PurhaseDate 'Alış Tarihi',p.IssueDate 'Veriş Tarihi',p.Status 'DURUMU',p.Note 'NOT'FROM Proccess p LEFT JOIN Students s ON p.StudentId = s.StudentId LEFT JOIN Books b ON p.BookId = b.BookId";

            return EntityList(query);
        }
        public DataTable ListSearch(string searchcontent)
        {
            string query = "SELECT p.ProccesId 'İŞLEM NO',s.StudentName +' '+ s.StudentSurname'AD SOYAD',b.BookName'KİTAP ADI' ,p.PurhaseDate 'Alış Tarihi',p.IssueDate 'Veriş Tarihi',p.Status 'DURUMU',p.Note 'NOT'FROM Proccess p LEFT JOIN Students s ON p.StudentId = s.StudentId LEFT JOIN Books b ON p.BookId = b.BookId " +
                "WHERE s.StudentName LIKE '%" + searchcontent + "%' ORDER BY ProccesId DESC ";

            return EntityList(query);
        }
        public DataTable ListLateProccessing()
        {
            string query = "SELECT p.ProccesId 'İŞLEM NO',s.StudentName +' '+ s.StudentSurname'AD SOYAD',b.BookName'KİTAP ADI' ,p.PurhaseDate 'Alış Tarihi',p.IssueDate 'Veriş Tarihi',p.Status 'DURUMU',p.Note 'NOT'FROM Proccess p LEFT JOIN Students s ON p.StudentId = s.StudentId LEFT JOIN Books b ON p.BookId = b.BookId" +
                " WHERE PurhaseDate <SUBSTRING('" + DateTime.Now + "',4,3)+SUBSTRING('" + DateTime.Now + "',1,3)+SUBSTRING('" + DateTime.Now + "',7,4) AND Status!='getirdi' ORDER BY PurhaseDate";

            return EntityList(query);
        }
        public DataTable ListUpComingProcess()
        {
            string query = "SELECT p.ProccesId 'İŞLEM NO',s.StudentName +' '+ s.StudentSurname'AD SOYAD',b.BookName'KİTAP ADI' ,p.PurhaseDate 'Alış Tarihi',p.IssueDate 'Veriş Tarihi',p.Status 'DURUMU',p.Note 'NOT'FROM Proccess p LEFT JOIN Students s ON p.StudentId = s.StudentId LEFT JOIN Books b ON p.BookId = b.BookId" +
                " WHERE PurhaseDate >=SUBSTRING('" + DateTime.Now + "',4,3)+SUBSTRING('" + DateTime.Now + "',1,3)+SUBSTRING('" + DateTime.Now + "',7,4) AND Status!='getirdi' ORDER BY PurhaseDate";

            return EntityList(query);
        }


        //public List<Procces> GetAllList()
        //{
        //    List<Procces> proccess = new List<Procces>();
        //    HandleException(() =>
        //    {
        //    //string query = "SELECT p.ProccesId 'İŞLEM NO',s.StudentName +' '+ s.StudentSurname'AD SOYAD',b.BookName'KİTAP ADI' ,p.PurhaseDate 'Alış Tarihi',p.IssueDate 'Teslim Tarihi',p.State 'DURUMU',p.Note 'NOT'FROM Process p LEFT JOIN Students s ON p.StudentId = s.StudentId LEFT JOIN Books b ON p.BookId = b.BookId";
        //    string query = "SELECT *FROM Proccess ";

        //        using (SqlCommand command = new SqlCommand(query, Connection()))
        //        {
        //            ConnectionOpenControl();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Procces procces = new Procces
        //                    {
        //                        ProccesId = Convert.ToInt32(reader["ProccesId"]),
        //                        StudentId = reader["StudentId"].ToString(),
        //                        BookId = Convert.ToInt32(reader["BookId"]),
        //                        PurhaseDate = Convert.ToDateTime(reader["PurhaseDate"]),
        //                        IssueDate = Convert.ToDateTime(reader["IssueDate"]),
        //                        Status = reader["Status"].ToString(),
        //                        Note = reader["Note"].ToString()
        //                    };
        //                    proccess.Add(procces);
        //                }
        //            }
        //        }
        //    });

        //    return proccess;
        //}
    }
}
