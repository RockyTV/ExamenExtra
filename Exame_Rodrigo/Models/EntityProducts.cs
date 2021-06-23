using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Models
{
    public class EntityProducts
    {
        public int id { get; set; }
        public string NameProduct { get; set; }
        public string ProductManufactured { get; set; }
        public int Cost { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}