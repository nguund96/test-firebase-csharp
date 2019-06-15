using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirebaseDatabase.Models
{
    public class Link
    {
        public string key { get; set; }
        public string link { get; set; }
        public string linkThumbnail { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int type { get; set; }
    }
}
