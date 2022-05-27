using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISK = IsKatmanı;
using VAR = Varlıklar;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OBS_1
{
    public partial class Form3 : Form
    {
        public VAR.ogrenci ogrenci;
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Owner = this;
            form4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            //Bu kısım diğer formdaki değişkenlere tabloda tıkladığın kaydın değerlerini atıyor

            form5.ogrno = int.Parse(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            form5.tcno=dataGridView2.CurrentRow.Cells[2].Value.ToString();
            form5.ogrAdSoyad = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            form5.ogrBolum = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            form5.sinif = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            form5.cep = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            form5.mail = dataGridView2.CurrentRow.Cells[7].Value.ToString();

           // dataGridView1.CurrentRow.Cells[2].Value.ToString();

            form5.Owner = this;
            form5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Owner = this;
            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Owner = this;
            form7.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Owner = this;
            form10.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Owner = this;
            form11.ShowDialog();
        }
        VeriErisimKatmanı.ders yeniders = new VeriErisimKatmanı.ders();
        DataTable dtders = new DataTable();
        VeriErisimKatmanı.ogrders yogrders = new VeriErisimKatmanı.ogrders();
        DataTable dtogrders = new DataTable();
        VeriErisimKatmanı.ogrenci yogrenci = new VeriErisimKatmanı.ogrenci();
        DataTable dtogr = new DataTable();
        public void ogrlistele()
        {
            dtogr = yogrenci.ogrliste();
            dataGridView2.DataSource = dtogr;
        }
        public void derslistele()
        {
            dtders = yeniders.dersliste();
            dataGridView3.DataSource = dtders;
        }
        public void ogrderslistele()
        {
            dtogrders = yogrders.ogrdersliste();
            dataGridView1.DataSource = dtogrders;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ogrlistele();
            derslistele();
            ogrderslistele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VAR.ogrenci ogrSil = new VAR.ogrenci(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
            yogrenci.ogrSil(ogrSil);
            ogrlistele();
            MessageBox.Show("Silme işlemi başarılı.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VAR.ders dersSil = new VAR.ders(Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value));
            yeniders.dersSil(dersSil);
             derslistele();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrenci Bilgi Otomasyonu 1.0");
        }

        private void kullanıcıGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.ShowDialog();
        }
    }
}
