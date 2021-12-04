using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vitrina.Models
{
    public class DevTeam
    {
        public int ID { get; set; }//+
        public string Name { get; set; } = string.Empty;//+
        public string ImageString { get; set; }
        public string Progects { get; set; }
        public string Desc { get; set; }
    }
}
