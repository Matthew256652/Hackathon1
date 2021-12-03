using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vitrina.Models
{
    public class StartupRequest
    {
        public int ID { get; set; }
        public string Problem { get; set; }
        public string Condition { get; set; }
        public string Risks { get; set; }
        public string Why { get; set; }
        public string Subject { get; set; }
        [DataType(DataType.Date)]
        public DateTime Terms { get; set; }
        public string SolveAttempts { get; set; }
        public string Company { get; set; }
        public string FIO { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
    }
}
