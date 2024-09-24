using Ejercicio01.Datos;
using Ejercicio01.Entidades;

namespace Ejercicio01.Windows
{
    public partial class frmCircunferencias : Form
    {
        private readonly Repositorio repositorio;
        private List<Circunferencia>? lista;
        public frmCircunferencias()
        {
            InitializeComponent();
            repositorio = new Repositorio();

        }



        private void frmCircunferencias_Load(object sender, EventArgs e)
        {
            var cantidad = repositorio.GetCantidad();
            ActualizarCantidadRegistros();
            if (cantidad == 0)
            {
                MessageBox.Show("No hay circunferencias todavía!!!",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
            }

        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var circagregada in lista!)
            {
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, circagregada);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Circunferencia circAgregada)
        {
            r.Cells[colRadio.Index].Value = circAgregada.Radio;
            r.Cells[colDiametro.Index].Value = circAgregada.GetDiametro().ToString("N2");
            r.Cells[colArco.Index].Value = circAgregada.GetLongArco().ToString("N2");
            r.Cells[colPerimetro.Index].Value = circAgregada.GetPerimetro().ToString("N2");
            r.Cells[colSuperficie.Index].Value = circAgregada.GetSuperficie().ToString("N2");

            r.Tag = circAgregada;//Guardar objeto en la prop tag
        }

        private DataGridViewRow ConstruirFila(DataGridView dgvDatos)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCircunferenciaAE frm = new frmCircunferenciaAE() { Text = "Agregar Circunferencia" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            Circunferencia? circAgregada = frm.GetCircunferencia();
            if (!repositorio.Existe(circAgregada))
            {
                repositorio.Agregar(circAgregada);
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, circAgregada);
                AgregarFila(r);
                MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarCantidadRegistros();

            }
            else
            {
                MessageBox.Show("Registro duplicado!!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCantidadRegistros()
        {
            txtCantidad.Text = repositorio.GetCantidad().ToString();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            var rBorrar = dgvDatos.SelectedRows[0];
            var circBorrar = rBorrar.Tag as Circunferencia;
            repositorio.Borrar(circBorrar);
            dgvDatos.Rows.Remove(rBorrar);
            MessageBox.Show("Registro borrado", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarCantidadRegistros();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var rSeleccionada = dgvDatos.SelectedRows[0];
            var circEditar = rSeleccionada.Tag as Circunferencia;
            frmCircunferenciaAE frm = new frmCircunferenciaAE() { Text = "Editar Circunferencia" };
            frm.SetCircunferencia(circEditar);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            circEditar = frm.GetCircunferencia();
            if (circEditar is not null)
            {
                SetearFila(rSeleccionada, circEditar);
                MessageBox.Show("Registro editado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarRadio frm = new frmBuscarRadio() { Text = "Ingrese Radio" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            var valorParaBuscar = frm.GetValorDeBusqueda();
            lista = repositorio.GetListaFiltrada(valorParaBuscar);
            MostrarDatosEnGrilla();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
