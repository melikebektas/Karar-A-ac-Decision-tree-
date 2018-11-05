using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karar_agaci
{
    
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            this.Width = 1700;
            this.Height = 800;
        }

        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue);
        private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.HotPink,3);
        Brush myBrush = new SolidBrush(Color.Blue);


        
        Font drawFont = new Font("Arial", 16);
        Font drawFont2 = new Font("Arial", 12);


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
            
       
        {
            
            DataTable tablo = new DataTable();
            tablo.Columns.Add("Hava");
            tablo.Columns.Add("Isı");
            tablo.Columns.Add("Nem");
            tablo.Columns.Add("Rüzgar");
            tablo.Columns.Add("Oyun");
            dataGridView1.DataSource = tablo;

            tablo.Rows.Add("güneşli", "sıcak", "yüksek", "hafif", "hayir");
            tablo.Rows.Add("güneşli", "sıcak", "yüksek", "kuvvetli", "hayir");
            tablo.Rows.Add("bulutlu", "sıcak", "yüksek", "hafif", "evet");
            tablo.Rows.Add("yağmurlu", "ılık", "yüksek", "hafif", "evet");
            tablo.Rows.Add("yağmurlu", "soğuk", "normal", "hafif", "evet");
            tablo.Rows.Add("yağmurlu", "soğuk", "normal", "kuvvetli", "hayir");
            tablo.Rows.Add("bulutlu", "soğuk", "normal", "kuvvetli", "evet");
            tablo.Rows.Add("güneşli", "ılık", "yüksek", "hafif", "hayir");
            tablo.Rows.Add("güneşli", "soğuk", "normal", "hafif", "evet");
            tablo.Rows.Add("yağmurlu", "ılık", "normal", "hafif", "evet");
            tablo.Rows.Add("güneşli", "ılık", "normal", "kuvvetli", "evet");
            tablo.Rows.Add("bulutlu", "ılık", "yüksek", "kuvvetli", "evet");
            tablo.Rows.Add("bulutlu", "sıcak", "normal", "hafif", "evet");
            tablo.Rows.Add("yağmurlu", "ılık", "yüksek", "kuvvetli", "hayir");



        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbHava.Text == "Güneşli" & cmbNem.Text == "Yüksek")
            { txtSonuc.Text = "Hayır"; }

            else if (cmbHava.Text == "Güneşli" & cmbNem.Text == "Normal")
            { txtSonuc.Text = "Evet"; }

            else if (cmbHava.Text == "Bulutlu")
            { txtSonuc.Text = "Evet"; }

            else if (cmbHava.Text == "Yağmurlu" & cmbRüzgar.Text == "Kuvvetli")
            { txtSonuc.Text = "Hayır"; }

            else if (cmbHava.Text == "Yağmurlu" & cmbRüzgar.Text == "Hafif")
            { txtSonuc.Text = "Evet"; }



        }

        private void btnAgc_Click(object sender, EventArgs e)
        {

            g = pictureBox1.CreateGraphics();
            
            Point drawPoint1 = new Point(325, 20);
            g.DrawString("Hava", drawFont, myBrush, drawPoint1);
            g.DrawEllipse(pen2, 300, 20, 120, 25);
            g.DrawLine(pen1, 350, 50, 350, 100);
            g.DrawLine(pen1, 350, 50, 300, 100);
            g.DrawLine(pen1, 350, 50, 435, 100);
            Point drawPoint2 = new Point(235, 95);
            Point drawPoint3 = new Point(325, 95);
            Point drawPoint4 = new Point(410, 95);
            g.DrawString("Güneşli", drawFont, myBrush, drawPoint2);
            g.DrawString("Bulutlu", drawFont, myBrush, drawPoint3);
            g.DrawString("Yağmurlu", drawFont, myBrush, drawPoint4);

           g.DrawLine(pen1, 350, 115, 350, 145);
           Point drawPoint6 = new Point(325, 150);

            g.DrawString("Evet", drawFont, myBrush, drawPoint6);
            g.DrawRectangle(pen2, 320, 142, 60, 40);
            g.DrawLine(pen1, 285, 115, 210, 175);

            Point drawPoint5 = new Point(185, 175);
             g.DrawString("Nem", drawFont, myBrush, drawPoint5);
             g.DrawEllipse(pen2, 155, 175, 120, 25);

            g.DrawLine(pen1, 100, 300, 200, 200);
            Point drawPoint7 = new Point(70, 290);
            g.DrawString("Yüksek", drawFont, myBrush, drawPoint7);

            g.DrawLine(pen1, 100, 310, 100, 400);
            Point drawPoint9 = new Point(75, 410);
            g.DrawRectangle(pen2, 75, 400, 60, 40);
            g.DrawString("Hayır", drawFont, myBrush, drawPoint9);

            g.DrawLine(pen1, 200, 200, 265, 285);
            Point drawPoint8 = new Point(225, 290);
            g.DrawString("Normal", drawFont, myBrush, drawPoint8);


            g.DrawLine(pen1, 270, 310, 270, 405);
            Point drawPoint10 = new Point(250, 410);
            g.DrawRectangle(pen2, 250, 400, 60, 40);
            g.DrawString("Evet", drawFont, myBrush, drawPoint10);

            g.DrawLine(pen1, 440, 100, 500, 170);
            Point drawPoint11 = new Point(460, 175);
            g.DrawString("Rüzgarlı", drawFont, myBrush, drawPoint11);
            g.DrawEllipse(pen2, 445, 175, 120, 25);

            g.DrawLine(pen1, 500, 200, 450, 265);
            Point drawPoint12 = new Point(400, 265);
            g.DrawString("Kuvvetli", drawFont, myBrush, drawPoint12);

            g.DrawLine(pen1, 500, 200, 550, 265);
            Point drawPoint13 = new Point(525, 265);
            g.DrawString("Hafif", drawFont, myBrush, drawPoint13);

            g.DrawLine(pen1, 560, 285, 560, 400);
            Point drawPoint14 = new Point(535, 405);
            g.DrawRectangle(pen2, 535, 400, 60, 40);
            g.DrawString("Evet", drawFont, myBrush, drawPoint14);

            g.DrawLine(pen1, 435, 410, 435, 295);
            Point drawPoint15 = new Point(400, 405);
            g.DrawRectangle(pen2, 400, 400, 60, 40);
            g.DrawString("Hayır", drawFont, myBrush, drawPoint15);


        }




        private void Form1_Paint(object sender, PaintEventArgs e)
        {
         
           
        }

        private void btnEntropi_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 4;
            int evet = 0;
            int hayir = 0;
            double entropiO = 0;
            double entropiI = 0;
            double entropiR = 0;
            double entropiN = 0;
            double entropiH = 0;

            double entropiO2 = 0;
            double entropiI2 = 0;
            double entropiN2 = 0;
            



            for (i = 0; i <= 13; i++)
                if (Convert.ToString(dataGridView1.Rows[i].Cells[j].Value).StartsWith("e") == true)
                {
                    evet++;

                }

                else
                {
                    hayir++;

                }

            entropiO += -(Convert.ToDouble(hayir) / 14 * (Math.Log((Convert.ToDouble(hayir) / 14), 2)) + Convert.ToDouble(evet) / 14 * (Math.Log((Convert.ToDouble(evet) / 14), 2)));
            listBox1.Items.Add("oyunun entropisi= " + entropiO.ToString());


            entropiI = 0.2857142857 * (0.811)+ 0.4285714286*(0.918)+ 0.2857142857*(1.0);
            entropiI = entropiO - entropiI;
            listBox1.Items.Add("ısının entropisi= " + entropiI.ToString());


            entropiR = 0.5714285714 * (0.811) + 0.4285714286 * (1.00) ;
            entropiR = entropiO - entropiR;
            listBox1.Items.Add("rüzgarın entropisi= " + entropiR.ToString());


            entropiN = 0.5 * (0.985) + 0.5*(0.592);
            entropiN = entropiO - entropiN;
            listBox1.Items.Add("nemin entropisi= " + entropiN.ToString());


            entropiH =  0.3571428571* (0.971) + 0.3571428571 * (0.971);
            entropiH = entropiO - entropiH;
            listBox1.Items.Add("havanın entropisi= " + entropiH.ToString());

            listBox1.Items.Add("Entropinin 2. adımı");


            entropiO2 = -(Convert.ToDouble(Math.Log((0.4), 2)*(0.4))+Convert.ToDouble(Math.Log((0.6),2)*(0.6)));
            listBox1.Items.Add("oyunun entropisi= " + entropiO2.ToString());

            entropiI2 = 0.4;
            entropiI2 = entropiO2 - entropiI2;
            listBox1.Items.Add("ısının entropisi= " + entropiI2.ToString());


            entropiN2 = entropiO2 - entropiN2;
            listBox1.Items.Add("nemin entropisi= " + entropiN2.ToString());

            listBox1.Items.Add("rüzgarın entropisi= 0.019434666" );




        }


        
    } 

    } 



