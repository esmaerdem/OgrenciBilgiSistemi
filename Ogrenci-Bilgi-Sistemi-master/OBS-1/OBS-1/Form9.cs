using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OBS_1
{
    public partial class Form9 : Form
    {
        public Varlıklar.ogrders ogrenci;
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True");
        VeriErisimKatmanı.ogrenci yeni = new VeriErisimKatmanı.ogrenci();
        DataTable yenidt = new DataTable();
        public void veri(int ogrno)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("ogrenciyigetir", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ogrno", ogrno);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form9_Load(object sender, EventArgs e)
        {

            //veri();
            //Form8 form8 = new Form8();
            //veri(Convert.ToInt32(form8.textBox1.Text));
        
                //SqlDataAdapter da = new SqlDataAdapter("ogrders", con);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //DataTable dt = new DataTable();
                //da.Fill(dt);

                //dataGridView1.DataSource = dt;

            //Yardimci.HataKaydet(new Exception("Hata kaydet testi"));
            //try
            //{
            //    ogrenci = IsKatmanı.ogrenci.OgrenciGetir(Yardimci.KullaniciNo);
            //    SqlDataAdapter da = new SqlDataAdapter();
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    Yardimci.HataKaydet(ex);
            //    MessageBox.Show("Serviste bir hata oluştu!");
            //}
        }
    }
}
