using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErenSevindikFlightApp.Models
{
    public class Rezervasyon
    {
        public int id { get; set; }
        public string KoltukNo { get; set; }
        public int LokasyonId { get; set; }

    }
}
