using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_is
{
    public partial class MangerUsers : Form
    {
        public MangerUsers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"DESKTOP-UIGA87S\SQLEXPRESS;Initial Catalog=inventar;Integrated
Security=True");

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into placiBaza values('"+UnameTb.Text+ "','" + FnameTb.Text + "','" + PasswordTb.Text + "')" ,con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Componenta adaugata cu succes");

            }
            catch
            {

            }
        }
    }
}
