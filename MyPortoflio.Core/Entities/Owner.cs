using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortoflio.Core.Entities
{
    public class Owner : EntityBase
    {

        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
}
