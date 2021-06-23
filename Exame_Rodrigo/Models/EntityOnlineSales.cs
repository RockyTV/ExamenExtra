using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Models
{
    public class EntityOnlineSales
    {
        public int Id { get; set; }
        public int IdCostumer { get; set; }
        public DateTime DateSystem { get; set; }
        public string Status { get; set; }
    }
}