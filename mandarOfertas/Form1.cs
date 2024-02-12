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

namespace mandarOfertas
{
    public partial class Form1 : Form
    {
      
       
        int totalContador =0;
        float progreso = 0;
        bool estado = true;
       


        public Form1()
        {
            InitializeComponent();
           

            

        }


        
       
        private async void btnIniciar_Click(object sender, EventArgs e)
        {




            if (txtContactos.Text == "")
            {
                MessageBox.Show("Ponga la cantidad de contactos a los que quiere enviar","Dato Vacio",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                txtContactos.Focus();
            }
            else
            {
                
                estado = true;
                Task tarea1 = new Task(() =>
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();

                });
                
               
                
                               
                btnIniciar.Enabled = false;
                btnStop.Enabled = true;
                btnStop.ForeColor = Color.Red;

                
                tarea1.Start();
                await tarea1;
                tarea1.Dispose();

                Task tarea2 = new Task(() =>
                {
                    string texto = txtTexto.Text;


                    
                    int pos = int.Parse(txtPos.Text);
                    int n = 0;
                    int cantidad = int.Parse(txtContactos.Text);
                    pbProgreso.Maximum = cantidad;
                    while (n < cantidad && estado == true)
                    {

                        // SendKeys.SendWait("{CTRL}" + "N");
                        Thread.Sleep(1000);
                        SendKeys.SendWait("^n");
                        Thread.Sleep(1000);
                        SendKeys.SendWait("{TAB}");
                        Thread.Sleep(500);
                        SendKeys.SendWait("{TAB}");
                        Thread.Sleep(500);
                        SendKeys.SendWait("{END}");
                        Thread.Sleep(500);
                        for (int i = 0; i <= n; i++)
                        {
                            if (i != 0)
                            {
                                SendKeys.SendWait("{UP}");
                                Thread.Sleep(50);
                            }


                        }
                        if (estado!=true)
                        {
                            
                            break;
                        }
                        if (pos > 0)
                        {
                            for (int i = 0; i <= pos - 1; i++)
                            {
                                SendKeys.SendWait("{UP}");
                                Thread.Sleep(50);

                            }
                            n = pos;
                            pos = 0;
                        }


                        Thread.Sleep(500);
                        SendKeys.SendWait("{ENTER}");
                        Thread.Sleep(1000);
                        if (chxPortapapeles.Checked)
                        {
                            SendKeys.SendWait("^v");
                            Thread.Sleep(3000);
                            if (chxIncluirTexto.Checked)
                            {
                                SendKeys.SendWait(texto);
                                Thread.Sleep(1000);
                            }
                            SendKeys.SendWait("{ENTER}");
                            Thread.Sleep(1000);

                        }
                        if (estado != true)
                        {

                            break;
                        }
                        if (!(txtTexto.Text == "") && !(chxIncluirTexto.Checked))
                        {
                            SendKeys.SendWait(texto);
                            Thread.Sleep(100);
                            SendKeys.SendWait("{ENTER}");
                            Thread.Sleep(100);
                        }
                        n++;
                        totalContador = n /*+ int.Parse(txtPos.Text)*/;
                        lblContador.Text = totalContador.ToString();

                        progreso = (float)(totalContador * 100) / cantidad;
                        pbProgreso.Value = totalContador;
                        if (progreso.ToString().Length > 4)
                        {
                            lblPorcentaje.Text = progreso.ToString().Insert(0, "%").Remove(5);
                        }
                        else
                        {
                            lblPorcentaje.Text = progreso.ToString().Insert(0, "%");
                        }

                        if (estado != true)
                        {

                            break;
                        }

                        Thread.Sleep(2000);
                        SendKeys.SendWait("^w");
                        Thread.Sleep(3000);
                        SendKeys.SendWait("+{F10}");
                        Thread.Sleep(1000);
                        for (int i = 0; i < 5; i++)
                        {
                            SendKeys.SendWait("{DOWN}");
                            Thread.Sleep(100);
                        }
                        SendKeys.SendWait("{ENTER}");
                        Thread.Sleep(1000);
                        SendKeys.SendWait("{ENTER}");
                        if (estado != true)
                        {

                            break;
                        }

                        Thread.Sleep(1000);
                        //SendKeys.SendWait("{ESC}");

                    }


                });

                while (estado)
                {
                    tarea2.Start();
                }
                
                await tarea2;
                tarea2.Dispose();



                
                
                              
             
                MessageBox.Show("Tarea terminada.. Mensajes enviados ", "Final",MessageBoxButtons.OK, MessageBoxIcon.Information);




                
            }


        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            pbProgreso.Minimum = 0;
 
            btnStop.Enabled = false;
            txtPos.Text = 0.ToString();
            

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = true;
            txtContactos.Text = "";
            lblContador.Text = 00.ToString();
            txtPos.Text = 0.ToString();
            estado=true;

            txtPos.Text = 0.ToString();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
                estado = false;
                
        }
    }
}
