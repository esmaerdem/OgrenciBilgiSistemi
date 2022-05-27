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
    public partial class Form11 : Form
    {
        public VAR.ogrders ogrenci;
        public Form11()
        {
            InitializeComponent();
            string con = "Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(con);
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select dersno from ders", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["dersno"]);
            }
        }
        private void NotGir()
        {
            textBox1.Text = ogrenci.Vize.ToString();
            textBox2.Text = ogrenci.Final.ToString();
        }
        VeriErisimKatmanı.ogrders yenikayit = new VeriErisimKatmanı.ogrders();
        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            string ortl;
            string harfn="";
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
           sonuc = (sayi1 * 0.3) + (sayi2 * 0.7);
            ortl = sonuc.ToString();
            if(sonuc<=100 && sonuc >= 90 )
            {
                harfn = "AA";
            }
            else if(sonuc<90 && sonuc >=80)
            {
                harfn = "BA";
            }
            else if (sonuc < 80 && sonuc >= 65)
            {
                harfn = "BB";
            }
            else if (sonuc < 65 && sonuc >= 50)
            {
                harfn = "CB";
            }
            else if (sonuc < 50 && sonuc > 40)
            {
                harfn = "CC";
            }
            else if (sonuc < 40)
            {
                harfn = "FF";
            }
            else if (sonuc < 90 && sonuc > 70)
            {
                harfn = "BA";
            }
            else if (sonuc < 90 && sonuc > 70)
            {
                harfn = "BA";
            }
            VAR.ogrders ykayit = new Varlıklar.ogrders(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), ortl, harfn);
            ykayit.Ogrid = yenikayit.ogrdersGuncelle(ykayit);
            ((Form3)this.Owner).ogrderslistele();

            this.Visible = false;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string con = "Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(con);
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select ogrid from ogrenci", baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2["ogrid"]);
            }
        }
    }
}
