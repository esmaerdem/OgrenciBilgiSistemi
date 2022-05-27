using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISK = IsKatmanı;
using VAR = Varlıklar;
using System.Data;
using System.Data.SqlClient;

namespace OBS_1
{
    public partial class Form10 : Form
    {
        public VAR.ogrders ogrenci;
        public Form10()
        {
            InitializeComponent();
           string con = "Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(con);
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select dersno from ders", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["dersno"]);
            }
        }
        private void DersAta()
        {
            comboBox1.SelectedText = ogrenci.Dersno.ToString();
        }

        VeriErisimKatmanı.ogrders yenikayit = new VeriErisimKatmanı.ogrders();
        private void button1_Click(object sender, EventArgs e)
        {
            VAR.ogrders ykayit = new Varlıklar.ogrders(Convert.ToInt32(comboBox2.Text), Convert.ToInt32(comboBox1.Text));
            //Convert.ToInt32(comboBox2.Text), Convert.ToInt32(comboBox1.Text)
            ykayit.Ogrid = yenikayit.ogrdersEkle(ykayit);
            ((Form3)this.Owner).ogrderslistele();

            this.Visible = false;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string con = "Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(con);
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select ogrid from ogrenci", baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2["ogrid"]);
            }
        }
    }
}
