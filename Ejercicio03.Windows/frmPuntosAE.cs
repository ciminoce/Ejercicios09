using Ejercicio03.Datos;
using Ejercicio03.Entidades;

namespace Ejercicio03.Windows
{
    public partial class frmPuntosAE : Form
    {
        private Punto? p;
        private Repositorio? repositorio;
        public frmPuntosAE()
        {
            InitializeComponent();
            repositorio = new Repositorio();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if(p is not null)
            {
                txtX.Text=p.X.ToString();
                txtY.Text=p.Y.ToString();
            }
        }
        public Punto? GetPunto()
        {
            return p;
        }

        public void SetPunto(Punto pEditar)
        {
            p = pEditar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (p is null)
                {
                    p = new Punto();

                }
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
            if (repositorio!.EstaRepetido(x, y))
            {
                valido = false;
                errorProvider1.SetError(txtY, "Punto existente");
            }
            return valido;
        }
    }
}
