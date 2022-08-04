using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_1
{
    class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public DateTime YearOfPublication { get; set; }
        public int PageNumber { get; set; }
        public int WriterId { get; set; }
        public int TypeId { get; set; }
        public int PublisherId { get; set; }
    }
}
