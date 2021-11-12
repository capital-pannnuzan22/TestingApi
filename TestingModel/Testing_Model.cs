using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestingModel
{
    public class Testing_Model
    {
        public SqlParameter[] Sqlprms { get; set; }

        public string Mode { get; set; }
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UpdateDate { get; set; }
    }
}
