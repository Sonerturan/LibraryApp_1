using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_1
{
    class Procces:BaseEntity
    {
        public int ProccesId { get; set; }
        public string StudentId { get; set; }
        public int BookId { get; set; }
        public DateTime PurhaseDate { get; set; }
        public DateTime IssueDate { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
    }
}
