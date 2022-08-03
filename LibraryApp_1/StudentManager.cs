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
    class StudentManager :BaseEntityDal, ICrudManager<Student>
    {
        public void Add(Student entity)
        {
            string query = "INSERT INTO Students(StudentId,StudentName,StudentSurname,StudentPhone,Department,Class,Gender,DateOfBirth) " +
                               "VALUES('" + entity.StudentId + "','" + entity.StudentName + "','" + entity.StudentSurname + "','" + entity.StudentPhone + "','" + entity.Department + "','" + entity.Class + "','" + entity.Gender + "',SUBSTRING('" + entity.DateOfBirth + "',4,3)+SUBSTRING('" + entity.DateOfBirth + "',1,3)+SUBSTRING('" + entity.DateOfBirth + "',7,4))";
            EntityAdd(query);
        }

        public void Delete(Student entity)
        {
            string query = "DELETE FROM Students WHERE StudentId='" + entity.StudentId + "'";
            EntityDelete(query);
        }
        public string registeredStudentId(string studentid)
        {
            string query = "SELECT * FROM Students WHERE StudentId='" + studentid + "'";
            string readered = "StudentId";
            return RegisteredControl(query, readered);
        }

        public void Update(Student entity)
        {
            string query = "UPDATE Students SET StudentName='" + entity.StudentName + "',StudentSurname='" + entity.StudentSurname + "',StudentPhone='" + entity.StudentPhone + "',Department='" + entity.Department + "',Class='" + entity.Class + "',Gender='" + entity.Gender + "',DateOfBirth=SUBSTRING('" + entity.DateOfBirth + "',4,3)+SUBSTRING('" + entity.DateOfBirth + "',1,3)+SUBSTRING('" + entity.DateOfBirth + "',7,4) WHERE StudentId='" + entity.StudentId + "'";
            EntityUpdate(query);
        }
        public DataTable ListBase()
        {
            string query = "Select StudentId 'Öğrenci No',StudentName 'AD',StudentSurname 'SOYAD',StudentPhone 'TELEFON',Department 'BÖLÜM',Class 'SINIF',Gender 'CİNSİYET',DateOfBirth 'Doğum Tarihi' FROM Students";

            return EntityList(query);
        }
        public DataTable ListSearch(string searchcontent)
        {
            string query = "Select StudentId 'Öğrenci No',StudentName 'AD',StudentSurname 'SOYAD',StudentPhone 'TELEFON',Department 'BÖLÜM',Class 'SINIF',Gender 'CİNSİYET',DateOfBirth 'Doğum Tarihi' FROM Students " +
                 "WHERE StudentName LIKE '%" + searchcontent.Trim().ToLower() + "%' OR StudentSurname LIKE '%" + searchcontent.Trim().ToLower() + "%' OR StudentName+' '+StudentSurname LIKE '%" + searchcontent.Trim().ToLower() + "%'";

            return EntityList(query);
        }

    }
}
