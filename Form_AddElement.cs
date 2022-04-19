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
    public partial class Form_AddElement : Form
    {
        User user = new User();
        List<string> pdrL = new List<string>();
        public Form_AddElement(string name, string pathToBase)
        {
            InitializeComponent();
            this.user.Name = name;
            this.user.PathToBase = pathToBase;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            pdrL = Base_Pdr();
        }

        private void Form_AddElement_Load(object sender, EventArgs e)
        {
            label1.Text = "Вы вошли как " + user.Name;
        }

        private void button1_Click(object sender, EventArgs e) //add content
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не заполненно поле что сделать", "Ошибка");
            }
            else
            {
                int index = 1;
                string content_ = File.ReadAllText(user.PathToBase, Encoding.Default);
                Decoding dc = new Decoding(content_);

                while (true) //считаем сколько есть элементов в базе чтоб не задвоился индекс
                {
                    dc.Skip("<index>");
                    string index_ = dc.ReadTo(">");
                    if (string.IsNullOrWhiteSpace(index_))
                    {
                        break;
                    }
                    index++;
                }

                    string content = (
                    Environment.NewLine +
                    "<index>" + index + ">" +
                    "<name>" + checkedListBox2.SelectedItem + ">" +
                    "<object>" + textBox3.Text + ">" +
                    "<what>" + textBox1.Text + ">" +
                    "<district>" + checkedListBox1.SelectedItem + ">" +
                    "<timeout>" + dateTimePicker1.Text + ">" +
                    "<timeadd>" + DateTime.Now + ">" +
                    "<whoadd>" + user.Name + ">"
                    );
                File.AppendAllText(user.PathToBase, content, Encoding.Default);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //add pordiadchick
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("В поле подрядчика ничего не введено", "Ошибка");
            }
            else
            {

                string content = (
                    Environment.NewLine +
                    "<index>" + "1" + ">" +
                    "<name>" + textBox2.Text + ">"
                    );
                File.AppendAllText("pdr.txt", content, Encoding.Default);
                checkedListBox2.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = String.Format("Вы выбрали: {0}", dateTimePicker1.Value.ToLongDateString());
        }

        private List<string> Base_Pdr()
        {
            List<string> pdrL = new List<string>();
            if (File.Exists("pdr.txt"))
            {
                string content = File.ReadAllText("pdr.txt", Encoding.Default);
                Decoding dc = new Decoding(content);
                while (true)
                {
                    dc.Skip("<name>");
                    string pdr = dc.ReadTo(">");

                    if (string.IsNullOrWhiteSpace(pdr))
                    {
                        break;
                    }
                    checkedListBox2.Items.Add(pdr);
                    pdrL.Add(pdr);
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
