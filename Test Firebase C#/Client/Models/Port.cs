using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirebaseDatabase.Models
{
    public class Port
    {
        public string portNumber { get; set; }
        public bool active { get; set; }
        public bool die { get; set; }
        public bool data { get; set; }
        public bool port { get; set; }
        public Dictionary<string, Link> links { get; set; }
    }
}
