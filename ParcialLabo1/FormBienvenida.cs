using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialLabo1
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        int contador = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;//aumentamos la opacidad en 0,05 en 30 milisegundos
                                                       //contador += 1;

            contador += 1;

            if (contador == 100)//cuando llega a 100 empieza el ultimo minutero
            {
                timerFadeIn.Stop();
                timerFadeOut.Start();
            }
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timerFadeOut.Stop();
                this.Close();
            }
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;

            timerFadeIn.Start();
        }
    }
}
