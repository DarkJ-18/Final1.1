using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Double prom;

            Double not1 = Convert.ToDouble(txtnota1.Text);
            Double not2 = Convert.ToDouble(txtnota2.Text);
            Double not3 = Convert.ToDouble(txtnota3.Text);
            Double not4 = Convert.ToDouble(txtnota3.Text);
            Double not5 = Convert.ToDouble(txtnota3.Text);
           

            prom = (not1 + not2 + not3 + not4 + not5) / 5.0;

            txttotal.Text = Convert.ToString(prom);

            if (prom <= 1)
            {
                MessageBox.Show("Reprueba la materia sin lograr realizar proceso de recuperación.");
                
            }

            else
            {
                if (prom <= 2.9)
                {
                    MessageBox.Show("Reprueba la materia y puede hacer la habilitación");
                    
                }
                else
                {
                    if (prom <= 3.9)
                    {
                        MessageBox.Show("Aprueba la materia con plan de mejora");
                        
                    }
                    else
                    {
                        if (prom <= 4.5)
                        {
                            MessageBox.Show("Buen rendimiento");
                            
                        }
                        else
                        {
                            if (prom <= 4.9)
                            {
                                MessageBox.Show("Excelente");
                                
                            }
                            else
                            {
                                if (prom == 5)
                                {
                                    MessageBox.Show("Graduado con honores!");
                                   

                                }
                            }
                        }
                    }
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
