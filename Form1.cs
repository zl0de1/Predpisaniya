using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //user.Name = "user";
            linkLabel1.Text = "Вы вошли как " + user.Name;

            var dir = new DirectoryInfo(Environment.CurrentDirectory + @"\bases");
            foreach (FileInfo file in dir.GetFiles())
            {
                comboBox1.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBase = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(selectedBase);
            
            string pathToBase = Environment.CurrentDirectory + @"\bases\" + selectedBase +".txt";
            
            user.PathToBase = pathToBase;

            List <Predpisanie> prd = new List<Predpisanie>(ReloadBase(pathToBase));
            dataGridView1.DataSource = prd;
            dataGridView1.Columns[0].Width = 33;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 203;
            dataGridView1.Columns[3].Width = 330;
            dataGridView1.Columns[4].Width = 105;
            dataGridView1.Columns[5].Width = 128;
            dataGridView1.Columns[6].Width = 128;
            dataGridView1.Columns[7].Width = 90;

            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " Кол-во элементов массива: " + prd.Count;
        }

        private void button1_Click(object sender, EventArgs e) //addFormGeneral
        {
            user.Name = "user";
            if (string.IsNullOrWhiteSpace(user.PathToBase))
            {
                MessageBox.Show("Не выбран месяц", "Ошибка");
            }
            else
            {
                Form_AddElement FrAdd = new Form_AddElement(user.Name, user.PathToBase);
                FrAdd.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) //reload
        {
            //ReloadBase();
        }

        private List<Predpisanie> ReloadBase(string path) //проверка наличия базы и загрузка
        {
            List<Predpisanie> prd = new List<Predpisanie>();
            if (File.Exists(path))
            {
                //dataGridView1.Rows.Clear();
                string content = File.ReadAllText(path, Encoding.Default);
                
                Decoding dc = new Decoding(content);
                while (true)
                {
                    dc.Skip("<index>");
                    string index_ = dc.ReadTo(">");

                    dc.Skip("<name>");
                    string nm = dc.ReadTo(">");

                    dc.Skip("<object>");
                    string obj = dc.ReadTo(">");

                    dc.Skip("<what>");
                    string what = dc.ReadTo(">");

                    dc.Skip("<district>");
                    string dst = dc.ReadTo(">");

                    dc.Skip("<timeout>");
                    string tout = dc.ReadTo(">");

                    dc.Skip("<timeadd>");
                    string tadd = dc.ReadTo(">");

                    dc.Skip("<whoadd>");
                    string wadd = dc.ReadTo(">");

                    if (string.IsNullOrWhiteSpace(index_))
                    {
                        dataGridView1.DataSource = prd;
                        return prd;
                    }
                    prd.Add(new Predpisanie(
                        Convert.ToInt32(index_),
                        nm,
                        obj,
                        what,
                        dst,
                        tout,
                        tadd,
                        wadd));
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
                return prd;
            }
        }
        
        //надо будет пихнуть в отдельный метод где то вне(лишний повтор в 2х классах)
        
    }
}
