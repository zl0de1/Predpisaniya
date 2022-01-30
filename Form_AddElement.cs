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
        public Form_AddElement(string name)
        {
            InitializeComponent();
            this.user.Name = name;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;

            string content = File.ReadAllText("base.txt", Encoding.Default);
            Decoding dc = new Decoding(content);
            while (true)
            {
                dc.Skip("<check>");
                string chk = dc.ReadTo(">");

                dc.Skip("<pordriadchick>");
                string pdr = dc.ReadTo(">");

                if (string.IsNullOrWhiteSpace(chk)) { break; }

                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    if (pdr == checkedListBox2.Items[i].ToString())
                    {
                        break;
                    }
                    else { checkedListBox2.Items.Add(pdr); }
                }


                //checkedListBox2.Items.Add(pdr);
            }
        }

        private void Form_AddElement_Load(object sender, EventArgs e)
        {
            label1.Text = "Вы вошли как " + user.Name;
        }

        private void button1_Click(object sender, EventArgs e) //add predpisanie
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не заполненно поле что сделать", "Ошибка");
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
                checkedListBox2.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = String.Format("Вы выбрали: {0}", dateTimePicker1.Value.ToLongDateString());
        }

    }
}
