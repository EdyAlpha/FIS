using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_is
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void label3_Click(object sender, EventArgs e)
        {
            UnabeTb.Text = "";
            PasswordTb.Text = "";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if ((UnabeTb.Text == "user") && (PasswordTb.Text == "pass"))
            {
                Form f = new Form2();
                f.ShowDialog();
            }
             else
                MessageBox.Show("Utilizator/Parola incorecte!");
        }

    }



}