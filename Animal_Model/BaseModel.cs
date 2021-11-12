using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Model
{
    class BaseModel
    {
        public string Mode { get; set; }
        public string SPName { get; set; }
        public SqlParameter[] Sqlprms { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string param1 { get; set; }
        public string param2 { get; set; }
    }
}
