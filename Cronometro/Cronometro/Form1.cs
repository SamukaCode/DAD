using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        DateTime inicio, fim;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath redondo = new GraphicsPath();
            redondo.AddEllipse(0, 0, 50, 50);
            button1.Region = new Region(redondo);
            button2.Region = new Region(redondo);
            button3.Region = new Region(redondo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio = DateTime.Now;
            timer1.Start();
            //timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*DateTime cron = Convert.ToDateTime(label1.Text);
            cron = cron.AddSeconds(1);
            string a = Convert.ToString(cron);
            label1.Text = a.Remove(0, 11);*/

            fim = DateTime.Now;
            TimeSpan dif = fim.Subtract(inicio);
            label1.Text = dif.ToString("hh\\:mm\\:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00:00";
        }
    }
}
