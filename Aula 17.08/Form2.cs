using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_17._08
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Incremento de 1 em 1 da barra de progresso.
            progressBar1.Increment(1);

            // Quando a barra estiver completa.
            if (progressBar1.Value == 100)
                timer1.Stop();
        }
    }
}
