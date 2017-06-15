using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleLedApp.Models
{
    public class status
    {
        public int id { get; set; }
        public int deviceId { get; set; }
        public int redPin { get; set; }
        public int greenPin { get; set; }
        public int bluePin { get; set; }
    }
}
