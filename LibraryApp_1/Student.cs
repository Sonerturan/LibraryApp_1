using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_1
{
    class Student:BaseEntity
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentPhone { get; set; }
        public string Department { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
