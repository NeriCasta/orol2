using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orol2
{
    public partial class Form1 : Form

    {



        public Form1()
        {
            InitializeComponent();

            DateTime dt = DateTime.Now;

            int hour = dt.Hour;
            int min = dt.Minute;
            int sec = dt.Second;
            lblM.Text = min.ToString("D2");
            lblS.Text = sec.ToString("D2");
            lblH.Text = hour.ToString("D2");


            Timer timer = new Timer();
            timer.Interval = 1000; // 1 secs 
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }



        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            int hour = dt.Hour;
            int min = dt.Minute;
            int sec = dt.Second;
            lblM.Text = min.ToString("D2");
            lblS.Text = sec.ToString("D2");
            lblH.Text = hour.ToString("D2");


            if (lblS.ForeColor == Color.Red)
            {
                lblS.ForeColor = System.Drawing.Color.Blue;
           }
            else
            {
                lblS.ForeColor = System.Drawing.Color.Red;
            }
        }




        DateTime premuto;

        Timer timer2 = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {


            button1.Visible = false;
            button2.Visible = true;
            premuto = DateTime.Now;

            timer2.Interval = 1 ; // 1 MS 
            timer2.Tick += new EventHandler(timer_Tick2);
            timer2.Start();


        }


        private void timer_Tick2(object sender, EventArgs e)
        {
            DateTime oracorrente = DateTime.Now;
            TimeSpan durata = oracorrente - premuto ;



            label4.Text = durata.Milliseconds.ToString("D3");
            label3.Text = durata.Seconds.ToString("D2");
            label2.Text = durata.Minutes.ToString("D2");
            label1.Text = durata.Hours.ToString("D2");
               


        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Visible = false;
            button1.Visible = true;


            DateTime oracorrente = DateTime.Now;
            TimeSpan durata = oracorrente - premuto;


            label4.Text = durata.Milliseconds.ToString("D3");
            label3.Text = durata.Seconds.ToString("D2");
            label2.Text = durata.Minutes.ToString("D2");
            label1.Text = durata.Hours.ToString("D2");
            timer2.Stop();  //stoppo il timer 2 
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label1.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu obj1 = new menu();
            obj1.Show();
            this.Hide();
        }

        private void toolllltip(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(this.pictureBox1, this.pictureBox1.Text = "VAI AL MENU");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
