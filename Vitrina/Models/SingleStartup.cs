using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vitrina.Models
{
    public class SingleStartup
    {
        public int ID { get; set; }//+
        public string DevTeam { get; set; } = string.Empty;//+
        public int State { get; set; }//+
        public string ShortDesc { get; set; } = string.Empty;//+
        public string Cases { get; set; } = string.Empty;
        public int Organisation { get; set; }
        public string Use { get; set; }//+
        public string RequestToAccelerator { get; set; }
        public int Sertification { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Company { get; set; }
        public int CompanyStaff { get; set; }
        public string Site { get; set; }
        public string AccInfSource { get; set; }
        public string PresentationLink { get; set; }
        public string Title { get; set; } = string.Empty;//+
        public string ImageAsString { get; set; }//+
        public string AlreadyRealised { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Price { get; set; }
        public string TechDir { get; set; } = string.Empty;
        public string TransportClass { get; set; } = string.Empty;




    }
}
