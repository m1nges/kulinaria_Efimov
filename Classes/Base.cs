using Npgsql;
using System;
using kulinaria_Efimov.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace kulinaria_Efimov.Classes
{
    public class Base
    {
        public int Base_id { get; set; }
        public string Base_name { get; set; }

        public Base(int base_id, string base_name)
        {
            Base_id = base_id;
            Base_name = base_name;
        }
    }
}
