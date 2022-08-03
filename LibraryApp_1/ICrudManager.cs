using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_1
{
    interface ICrudManager<BaseEntity>
    {
        void Add(BaseEntity entity);
        void Update(BaseEntity entity);
        void Delete(BaseEntity entity);
        DataTable ListBase();
        DataTable ListSearch(string searchcontent);
    }
}
