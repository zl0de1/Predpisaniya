using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Street
    {
        private string name;
        private int length;
        public Street() { }
        public Street(string name, int length)
        {

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
    }
}
