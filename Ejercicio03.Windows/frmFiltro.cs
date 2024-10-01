using Ejercicio03.Entidades;

namespace Ejercicio03.Windows
{
    public partial class frmFiltro : Form
    {
        private Cuadrante cuadranteSeleccionado;
        public frmFiltro()
        {
            InitializeComponent();
        }

        private void frmFiltro_Load(object sender, EventArgs e)
        {
            cboCuadrantes.DataSource = Enum.GetValues(typeof(Cuadrante));
            cboCuadrantes.SelectedIndex = 0;
            cboCuadrantes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cuadranteSeleccionado =(Cuadrante)cboCuadrantes.SelectedItem!;
            DialogResult = DialogResult.OK;
        }

        public Cuadrante GetCuadrante()
        {
            return cuadranteSeleccionado;
        }
    }
}
