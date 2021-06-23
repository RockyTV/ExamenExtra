using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Models
{
    public class EntityResponse
    {
        public string message { get; set; }
        public EntityState[] state { get; set; }
        public EntityMunicipalities[] municipality { get; set; }
        public EntityCostumers[] costumer { get; set; }
        public EntityOnlineSales[] Sale { get; set; }
        public EntitySaleDetails[] Detail { get; set; }
        public EntityProducts[] Product { get; set; }

        
    }
}