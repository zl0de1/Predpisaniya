using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Podriadchik
    {
        public string Name { get; set; }
        public string GpdNumber { get; set; }
        public string Date { get; set; }
        public Podriadchik() { }
        public Podriadchik(string name, string gpdNumber, string date)
        {
            this.Name = name;
            this.GpdNumber = gpdNumber;
            this.Date = date;
        }
    }
}
