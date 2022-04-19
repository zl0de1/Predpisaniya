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
        private string pathToBase;
        public User() { }
        public User(string name)
        {

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string PathToBase
        {
            get { return pathToBase; }
            set { pathToBase = value; }
        }
    }
}
