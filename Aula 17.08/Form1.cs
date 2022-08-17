using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_17._08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread thread = new Thread(new ThreadStart(splashScreen));
            thread.Start();
            Thread.Sleep(8000);

            InitializeComponent();

            thread.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splashScreen()
        {
            Application.Run(new SplashScreen());
        }
    }
}
