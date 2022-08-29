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


namespace EntityExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLectureList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NB43UN3;Initial Catalog=DbSınavÖğrenci;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * From TBLDERSLER", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //sqlden data çekmek için kullanılan yöntemlerden biri. diğerleri de aşağıdaki metodlarda

            //yukarıdaki gibi de yapılabilir aşağıdaki gibi de//

            //DbSınavÖğrenciEntities lec = new DbSınavÖğrenciEntities(); 
            //dataGridView1.DataSource = lec.TBLDERSLER.ToList();

        }


        DbSınavÖğrenciEntities db = new DbSınavÖğrenciEntities();  //metodun dışına çıkardık, artık tüm metodlarda kullanılabilir
        private void BtnStudentList_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.TBLOGRENCİ.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            //3. ve 4. sütunları görmemek için yukarıdaki kod yazıldı

            //sqlden data çekmek için kullanılan yöntemlerden diğeri.

        }

        private void BtnNoteList_Click(object sender, EventArgs e) //ÖNEMLİ
        {
            var query = from item in db.TBLNOTLAR
                        select new
                        {
                            item.NOTID,
                            item.TBLOGRENCİ.AD,
                            item.TBLOGRENCİ.SOYAD,
                            item.TBLDERSLER.DERSAD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dataGridView1.DataSource = query.ToList();
            //sadece sqldeki görmek istediğimiz sütunları görmek için yukarıdaki kod yazıldı
            //dataGridView1.DataSource=db.TBLNOTLAR.ToList();
            //sqlden data çekmek için kullanılan yöntemlerden diğeri.

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TBLOGRENCİ t = new TBLOGRENCİ();
            t.AD = TxtStudentName.Text;
            t.SOYAD = TxtStudentSurname.Text;
            db.TBLOGRENCİ.Add(t);
            db.SaveChanges();
            MessageBox.Show("New student added to list");

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtStudentID.Text);
            var x = db.TBLOGRENCİ.Find(id);
            db.TBLOGRENCİ.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Student removed from the system");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtStudentID.Text);
            var y = db.TBLOGRENCİ.Find(id);
            y.AD = TxtStudentName.Text;
            y.SOYAD = TxtStudentSurname.Text;
            y.FOTOGRAF = TxtPhoto.Text;
            db.SaveChanges();
            MessageBox.Show("Info updated");

        }

        private void BtnProcedure_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();




        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCİ.Where(x => x.AD == TxtStudentName.Text & x.SOYAD == TxtStudentSurname.Text).ToList();


        }

        private void TxtStudentName_TextChanged(object sender, EventArgs e)
        {
            string aranan = TxtStudentName.Text;
            var degerler = from item in db.TBLOGRENCİ
                           where item.AD.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void TxtStudentSurname_TextChanged(object sender, EventArgs e)
        {
            string arananSoyad = TxtStudentSurname.Text;
            var degerlerSoyad = from item in db.TBLOGRENCİ
                                where item.SOYAD.Contains(arananSoyad)
                                select item;
            dataGridView1.DataSource = degerlerSoyad.ToList();
        }

        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //asc sıralama (artan)
                List<TBLOGRENCİ> list1 = db.TBLOGRENCİ.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = list1;

            }

            if (radioButton2.Checked == true)
            {
                //desc sıralama (azalan)
                List<TBLOGRENCİ> list2 = db.TBLOGRENCİ.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = list2;

            }

            if (radioButton3.Checked == true)
            {
                List<TBLOGRENCİ> list3 = db.TBLOGRENCİ.OrderBy(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = list3;

            }

            if (radioButton4.Checked == true)
            {
                List<TBLOGRENCİ> list4 = db.TBLOGRENCİ.Where(p => p.ID == 5).ToList();
                dataGridView1.DataSource = list4;


            }

            if (radioButton5.Checked == true)
            {
                List<TBLOGRENCİ> list5 = db.TBLOGRENCİ.Where(p => p.AD.StartsWith("A")).ToList();
                dataGridView1.DataSource = list5;

            }

            if (radioButton6.Checked == true)
            {
                List<TBLOGRENCİ> list6 = db.TBLOGRENCİ.Where(p => p.AD.EndsWith("A")).ToList();
                dataGridView1.DataSource = list6;
            }

            if (radioButton7.Checked == true)
            {
                bool deger = db.TBLKULUPLER.Any();
                MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


            if (radioButton8.Checked == true)
            {
                int total = db.TBLOGRENCİ.Count();
                MessageBox.Show(total.ToString(), "Total Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton9.Checked == true)
            {
                var total = db.TBLNOTLAR.Sum(p => p.SINAV1);
                MessageBox.Show("Total Exam1 Score: " + total.ToString());


            }

            if (radioButton10.Checked == true)
            {

                var average = db.TBLNOTLAR.Average(p => p.SINAV1);
                MessageBox.Show("Average of Exam1: " + average.ToString());
            }

            if (radioButton11.Checked == true)
            {
                var highest = db.TBLNOTLAR.Max(p => p.SINAV1);
                MessageBox.Show("Highest Score in Exam1: " + highest.ToString());


            }

            if (radioButton12.Checked == true)
            {
                var lowest = db.TBLNOTLAR.Min(p => p.SINAV1);
                MessageBox.Show("Lowest Score in Exam1: " + lowest.ToString());


            }


        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBLNOTLAR
                        join d2 in db.TBLOGRENCİ
                        on d1.OGR equals d2.ID
                        join d3 in db.TBLDERSLER
                        on d1.DERS equals d3.DERSID
                        select new
                        {
                            STUDENT = d2.AD /*+ ' ' + d2.SOYAD*/,
                            SOYAD = d2.SOYAD,
                            LESSON = d3.DERSAD,
                            EXAM1 = d1.SINAV1,
                            EXAM2 = d1.SINAV2,
                            EXAM3 = d1.SINAV3,
                            AVERAGE = d1.ORTALAMA,
                        };
            dataGridView1.DataSource = sorgu.ToList();

        }
    }
}
