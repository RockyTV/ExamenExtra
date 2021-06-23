using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Models
{
    public class EntitySaleDetails
    {
        public int id { get; set; }
        public int idOnlineSale { get; set; }
        public int idProduct { get; set; }
        public int NumberOfProduct { get; set; }
        public int Cost { get; set; }
    }
}