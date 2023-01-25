using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortoflio.Core.Entities
{
    public class Address : EntityBase
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
    }
}

