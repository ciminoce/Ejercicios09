using Ejercicio03.Datos;
using Ejercicio03.Entidades;

namespace Ejercicio03.Windows
{
    public partial class frmPuntos : Form
    {
        private Repositorio repositorio;
        private List<Punto> listaPuntos;
        private int cantidad;
        public frmPuntos()
        {
            InitializeComponent();
            repositorio = new Repositorio();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPuntos_Load(object sender, EventArgs e)
        {
            cantidad = repositorio.GetCantidad();
            if (cantidad > 0)
            {
                listaPuntos = repositorio.GetLista();
                MostrarDatosEnGrilla();
                ActualizarCantidadRegistros();
            }
        }

        private void ActualizarCantidadRegistros()
        {
            txtCantidad.Text = cantidad.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var item in listaPuntos)
            {
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, item);
                AgregarFila(r, dgvDatos);
            }
        }

        private void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Punto item)
        {
            r.Cells[colPunto.Index].Value = item.ToString();
            r.Cells[colCuadrante.Index].Value = item.GetCuadrante();
            r.Cells[colDistanciaOrigen.Index].Value = item.GetDistanciaAlOrigen().ToString("N2");

            r.Tag = item;
        }

        private DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPuntosAE frm = new frmPuntosAE() { Text = "Agregar Punto" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            Punto pIngresado = frm.GetPunto();
            repositorio.Agregar(pIngresado);
            var r = ConstruirFila(dgvDatos);
            SetearFila(r, pIngresado);
            AgregarFila(r, dgvDatos);
            MessageBox.Show("Registro agregado!!!",
                "Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            cantidad = repositorio.GetCantidad();
            ActualizarCantidadRegistros();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Punto pBorrar =(Punto) r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el punto {pBorrar.ToString()}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            repositorio.Eliminar(pBorrar);
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Registro eliminado!!!",
                "Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            cantidad = repositorio.GetCantidad();
            ActualizarCantidadRegistros();

        }
    }
}
