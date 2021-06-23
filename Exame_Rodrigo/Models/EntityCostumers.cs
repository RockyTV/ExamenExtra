using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Models
{
    public class EntityCostumers
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string lastname { get; set; }
        public string surname { get; set; }
        public int gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int idMunicipality { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public DateTime DateSystem { get; set; }
    }
}