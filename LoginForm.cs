﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.Name = textBox1.Text;
            }
            catch
            {

            }
            Form1 fr = new Form1();
            fr.Show();
            //Close();
        }
    }
}
