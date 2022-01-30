using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class User
    {
        private string name;
        public User() { }
        public User(string name)
        {

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
