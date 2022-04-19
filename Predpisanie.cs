using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Predpisanie
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Object_ { get; set; }
        public string What { get; set; }
        public string District { get; set; }
        public string Timeout { get; set; }
        public string Timeadd { get; set; }
        public string Whoadd { get; set; }
        public Predpisanie() { }
        public Predpisanie(
            int index,
            string name,
            string object_,
            string what,
            string district,
            string timeout,
            string timeadd,
            string whoadd)
        {
            this.Index = index;
            this.Name = name;
            this.Object_ = object_;
            this.What = what;
            this.District = district;
            this.Timeout = timeout;
            this.Timeadd = timeadd;
            this.Whoadd = whoadd;
        }
    }
}
