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
        public string FullName { get; set; }
        public string GpdNumber { get; set; }
        public string Date { get; set; }
        public string Inn { get; set; }
        public string Email { get; set; }
        public Podriadchik() { }
        public Podriadchik(string name,string fullName, string gpdNumber, string date, string inn, string email)
        {
            this.Name = name;
            this.FullName = fullName;
            this.GpdNumber = gpdNumber;
            this.Date = date;
            this.Inn = inn;
            this.Email = email;
        }
    }
}
