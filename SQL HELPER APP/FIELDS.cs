using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_HELPER_APP
{
    class FIELDS
    {
        public string NAME { get; set; } = string.Empty;
        public string TYPE { get; set; } = "NVarchar";
        public string LENGTH { get; set; } = "255";
        public bool ISNULL { get; set; } = true;
    }
}
