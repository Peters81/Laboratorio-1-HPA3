namespace Pract1_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtDia.Text != "" && txtMes.Text != "" && txtAnio.Text != "")
            {
                if (int.TryParse(txtDia.Text, out _) && int.TryParse(txtMes.Text, out _) && int.TryParse(txtAnio.Text, out _))
                {
                    respuesta.Text = txtDia.Text + "/" + txtMes.Text + "/" + txtAnio.Text;
                }
                else
                {
                    MessageBox.Show("Los campos deben ser números válidos");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todo los campos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la aplicacion", "Close", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close( );
        }
    }
}

