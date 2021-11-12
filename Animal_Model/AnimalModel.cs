using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Model
{
    public class AnimalModel
    {
        public SqlParameter[] Sqlprms { get; set; }
        public string UpdatedBy { get; set; }
        public string Mode { get; set; }
        public string AnimalCD { get; set; }
        public string AnimalName { get; set; }
        public string Description { get; set; }
        public string UpdateDate { get; set; }
    }
}
