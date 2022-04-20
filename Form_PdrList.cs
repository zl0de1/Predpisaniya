using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form_PdrList : Form
    {
        User user = new User();
        public Form_PdrList(string name)
        {
            InitializeComponent();
            this.user.Name = name;

            List<Podriadchik> pdrsList = new List<Podriadchik>();
            //listBoxPdr.Items.Add(pdrsList);
        }

        private void Form_PdrList_Load(object sender, EventArgs e)
        {
            listBoxPdr.SelectedIndexChanged += listBoxPdr_Selected;
            
        }
        private void listBoxPdr_Selected(object sender, EventArgs e)
        {

        }
    }
}
