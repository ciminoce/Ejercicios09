namespace Ejercicio01.Windows
{
    public partial class frmBuscarRadio : Form
    {
        private int valorDeBusqueda;
        public frmBuscarRadio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            valorDeBusqueda =(int)nudRadio.Value;
            DialogResult=DialogResult.OK;
        }
        public int GetValorDeBusqueda()
        {
            return valorDeBusqueda;
        }

    }
}
