using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mandarOfertas
{
    public partial class Form2 : Form
    {
        int seg = 10;
        public Form2()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
            lblRestante.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblRestante.Visible=true;
            timer1.Start();
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            seg--;
            if (seg > 0)
            {
                lblRestante.Text = seg.ToString();
            }
            else 
            {
                lblRestante.Visible = false;
                timer1.Stop();
                this.Close();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
