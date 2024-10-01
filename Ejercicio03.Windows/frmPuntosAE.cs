using Ejercicio03.Datos;
using Ejercicio03.Entidades;
using System.Runtime.CompilerServices;

namespace Ejercicio03.Windows
{
    public partial class frmPuntosAE : Form
    {
        private Punto? p;
        private Repositorio? repositorio;
        public frmPuntosAE()
        {
            InitializeComponent();
            repositorio= new Repositorio();
        }

        public Punto GetPunto()
        {
            return p;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                p = new Punto();
                p.X = int.Parse(txtX.Text);
                p.Y = int.Parse(txtY.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtX.Text, out int x))
            {
                valido = false;
                errorProvider1.SetError(txtX, "Coord. X mal ingresada o falta");
            }
            if (!int.TryParse(txtY.Text, out int y))
            {
                valido = false;
                errorProvider1.SetError(txtY, "Coord. Y mal ingresada o falta");
            }
            if(repositorio!.EstaRepetido(x, y))
            {
                valido = false;
                errorProvider1.SetError(txtY, "Punto existente");
            }
            return valido;
        }
    }
}
