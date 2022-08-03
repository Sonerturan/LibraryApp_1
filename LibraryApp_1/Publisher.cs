using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_1
{
    class Publisher:BaseEntity
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; internal set; }
        public string PublisherAdress { get; set; }
        public string PublisherPhone { get; set; }
    }
}
