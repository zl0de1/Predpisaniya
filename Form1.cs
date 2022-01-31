using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using Newtonsoft.Json;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        User user = new User();
        List<string> podriadchiki = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
            ReloadBase(podriadchiki);
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //user.Name = "user";
            linkLabel1.Text = "Вы вошли как " + user.Name;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            user.Name = "user";
            Form_AddElement FrAdd = new Form_AddElement(user.Name);
            FrAdd.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e) //reload
        {
            ReloadBase(podriadchiki);
        }

        private void ReloadBase(List<string> podriadchiki) //проверка наличия базы
        {

            if (File.Exists("base.txt"))
            {
                listView1.Items.Clear();
                string content = File.ReadAllText("base.txt", Encoding.Default);

                Decoding dc = new Decoding(content);
                while (true)
                {
                    dc.Skip("<check>");
                    string chk = dc.ReadTo(">");

                    dc.Skip("<what>");
                    string what = dc.ReadTo(">");

                    dc.Skip("<pordriadchick>");
                    string pdr = dc.ReadTo(">");

                    dc.Skip("<district>");
                    string dst = dc.ReadTo(">");

                    dc.Skip("<timeout>");
                    string tout = dc.ReadTo(">");

                    dc.Skip("<timeadd>");
                    string tadd = dc.ReadTo(">");

                    dc.Skip("<whoadd>");
                    string wadd = dc.ReadTo(">");

                    if (string.IsNullOrWhiteSpace(chk))
                    {
                        break;
                    }

                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        chk,
                        what,
                        pdr,
                        dst,
                        tout,
                        tadd,
                        wadd });

                    listView1.Items.Add(listViewItem);
                }

            }
            else 
            {
                DialogResult result = MessageBox.Show(
                    "Файл с базой не найден\n Создать новый пустой?",
                    "Ошибка", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    File.Create("base.txt");
                }
                //this.TopMost = true;
            }
        }
    }
}
