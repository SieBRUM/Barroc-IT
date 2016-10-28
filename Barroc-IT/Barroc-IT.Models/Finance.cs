using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_IT.Models
{
    public class Finance
    {
        public string bankAccount { get; set; }
        public double saldo { get; set; }        
        public int invoiceCount { get; set; }
        public double profit { get; set; }
        public double limit { get; set; }
        public int maintenanceContract { get; set; }
    }
}
