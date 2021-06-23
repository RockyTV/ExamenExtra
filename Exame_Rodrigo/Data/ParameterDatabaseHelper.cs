using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Data
{
    public class ParameterDataBaseHelper
    {
        public string storedProcedureName { get; set; }
        public SqlParameter[] parameters { get; set; }
    }
}