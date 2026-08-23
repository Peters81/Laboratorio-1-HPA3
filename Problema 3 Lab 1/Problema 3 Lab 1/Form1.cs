namespace Problema_3_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void RealizarOperacion()
        {
            // Verificamos que las cajas tengan números para que no dé error si están vacías
            if (double.TryParse(txtnumero1.Text, out double num1) && double.TryParse(txtnumero2.Text, out double num2))
            {
                double resultado = 0;

                if (RbtnSuma.Checked)
                {
                    lbloperador.Text = "+";
                    resultado = num1 + num2;
                }
                else if (RbtnResta.Checked)
                {
                    lbloperador.Text = "-";
                    resultado = num1 - num2;
                }
                else if (RbtnMultiplicacion.Checked)
                {
                    lbloperador.Text = "*";
                    resultado = num1 * num2;
                }
                else if (RbtnDivision.Checked)
                {
                    lbloperador.Text = "/";
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        txtResultado.Text = "Error";
                        return;
                    }
                }

               
                txtResultado.Text = resultado.ToString();
            }
        }

        private void RbtnSuma_CheckedChanged(object sender, EventArgs e)
        {
            RealizarOperacion();
        }

        private void RbtnResta_CheckedChanged(object sender, EventArgs e)
        {
            RealizarOperacion();
        }

        private void RbtnMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            RealizarOperacion();
        }

        private void RbtnDivision_CheckedChanged(object sender, EventArgs e)
        {
            RealizarOperacion();
        }

        private void txtnumero1_TextChanged(object sender, EventArgs e)
        {
            RealizarOperacion();
        }

        private void txtnumero2_TextChanged(object sender, EventArgs e)
        {
            RealizarOperacion();
        }
    }
}
