using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirebaseDatabase.Models
{
    public class IP
    {
        public string ipAddress { get; set; }
        public bool availability { get; set; }
        public Dictionary<string, Port> ports { get; set; }
    }
}
