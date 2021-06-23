using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Models
{
    public class EntityMunicipalities
    {
        public int Id { get; set; }
        public int IdState { get; set; }
        public string MunicipalityName { get; set; }
        public int IsMetropolitanArea { get; set; }

    }
}