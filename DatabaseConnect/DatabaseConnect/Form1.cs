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
namespace DatabaseConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OkulVeritabanı;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAc_Click(object sender, EventArgs e)
        {
            if (baglanti.State.ToString()=="Closed")
            {
                baglanti.Open();
                MessageBox.Show("Veritabanı ile Bağlantı sağlandı.");
            }
            else
            {
                MessageBox.Show("Bağlantı Zaten Açık");
            }
            
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            if (baglanti.State.ToString() == "Open")
            {
                baglanti.Close();
                MessageBox.Show("Veritabanı ile Bağlantı kesildi.");
            }
            else
            {
                MessageBox.Show("Bağlantı zaten Kapalı");
            }
        }

        private void buttonDurum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baglanti.State.ToString());
        }
    }
}
