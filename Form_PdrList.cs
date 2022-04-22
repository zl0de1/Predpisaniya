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
        List<Podriadchik> pdrsList = new List<Podriadchik>(Base_Pdr());
        public Form_PdrList(string name)
        {
            InitializeComponent();
            this.user.Name = name;

            foreach (Podriadchik pdr in pdrsList)
            {
                listBoxPdr.Items.Add(pdr.Name);
            }
        }
        private void Form_PdrList_Load(object sender, EventArgs e)
        {
            listBoxPdr.SelectedIndexChanged += listBoxPdr_Selected;         
        }
        private void listBoxPdr_Selected(object sender, EventArgs e)
        {
            textBox_fullName.Text = pdrsList[listBoxPdr.SelectedIndex].FullName;
            textBox_gpdNumber.Text = pdrsList[listBoxPdr.SelectedIndex].GpdNumber + " от " + pdrsList[listBoxPdr.SelectedIndex].Date;
            textBox_inn.Text = pdrsList[listBoxPdr.SelectedIndex].Inn;
            textBox_email.Text = pdrsList[listBoxPdr.SelectedIndex].Email;
            StreetList(Convert.ToString(listBoxPdr.SelectedItem));
        }
        private void StreetList(string podriadchik)
        {
            listViewStreets.Items.Clear();
            //List<Street> Street_list = new List<Street>();
            //ListViewItem Streets = new ListViewItem();
            string content = File.ReadAllText(Environment.CurrentDirectory + @"\bases\streets\" + podriadchik + ".txt", Encoding.Default);
            Decoding dc = new Decoding(content);
            while (true)
            {
                dc.Skip("<name>");
                string name = dc.ReadTo(">");
                dc.Skip("<length>");
                string length = dc.ReadTo(">");
                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                //Street_list.Add(new Street(name, Convert.ToInt32(length)));
                listViewStreets.Items.Add(name, Convert.ToInt32(length));
                

            }
        }


        private static List<Podriadchik> Base_Pdr()
        {
            List<Podriadchik> pdrL = new List<Podriadchik>();
            if (File.Exists("pdr.txt"))
            {
                string content = File.ReadAllText("pdr.txt", Encoding.Default);
                Decoding dc = new Decoding(content);
                while (true)
                {
                    dc.Skip("<name>");
                    string name = dc.ReadTo(">");
                    dc.Skip("<fullname>");
                    string fullname = dc.ReadTo(">");
                    dc.Skip("<gpdNumber>");
                    string gpdNumber = dc.ReadTo(">");
                    dc.Skip("<date>");
                    string date = dc.ReadTo(">");
                    dc.Skip("<inn>");
                    string inn = dc.ReadTo(">");
                    dc.Skip("<email>");
                    string email = dc.ReadTo(">");

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        break;
                    }
                    Podriadchik pr_ = new Podriadchik(name, fullname, gpdNumber, date, inn, email);
                    pdrL.Add(pr_);
                }
                return pdrL;
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Файл с базой подрядчиков не найден\n Создать новый пустой?",
                    "Ошибка",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    File.Create("pdr.txt");
                }
                return pdrL;
            }
        }
    }
}
