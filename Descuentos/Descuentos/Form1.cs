namespace Descuentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorVenta;
            decimal descuentoPorcentaje = 0m;
            decimal descuentoVenta = 0m;
            decimal valorFinalVenta = 0m;

            if (decimal.TryParse(txtVENTA.Text, out valorVenta))
            {

                if (valorVenta >= 500m)
                {
                    descuentoPorcentaje = 0.30m;
                }
                else if (valorVenta >= 300m && valorVenta <= 499m)
                {
                    descuentoPorcentaje = 0.20m;
                }
                else if (valorVenta >= 100m && valorVenta <= 299m)
                {
                    descuentoPorcentaje = 0.10m;
                }
                else
                {
                    descuentoPorcentaje = 0m;
                }

                descuentoVenta = valorVenta * descuentoPorcentaje;
                valorFinalVenta = valorVenta - descuentoVenta;

                txtDescuento2.Text = (descuentoPorcentaje * 100).ToString() + " %";
                txtVentaFinal.Text = valorFinalVenta.ToString();
                txtDescuento1.Text = descuentoVenta.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVENTA.Text = " ";
            txtDescuento2.Text = " ";
            txtVentaFinal.Text = " ";
            txtDescuento1.Text = " ";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la aplicacion", "Close", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}   
