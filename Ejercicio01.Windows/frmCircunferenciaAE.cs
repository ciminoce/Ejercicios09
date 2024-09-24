using Ejercicio01.Datos;
using Ejercicio01.Entidades;
using System.Text;

namespace Ejercicio01.Windows
{
    public partial class frmCircunferenciaAE : Form
    {
        private Circunferencia? circFormulario;
        private readonly Repositorio repositorio;
        public frmCircunferenciaAE()
        {
            InitializeComponent();
            repositorio=new Repositorio();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (circFormulario != null)
            {
                txtRadio.Text = circFormulario.Radio.ToString();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var radio = int.Parse(txtRadio.Text);
                if (circFormulario == null)
                {
                    circFormulario = new Circunferencia();
                }
                circFormulario.Radio=radio;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Radio.....:{circFormulario.Radio}");
                sb.AppendLine($"Perímetro.: {circFormulario.GetPerimetro():N2}");
                sb.AppendLine($"Superficie: {circFormulario.GetSuperficie():N2}");
                MessageBox.Show(sb.ToString(), "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            } 
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            int radio;
            if (!int.TryParse(txtRadio.Text,out radio) 
                ||(radio<=0))
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "Radio no válido!!!");
            }
            if (repositorio.ExisteRadio(radio))
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "Radio existente!!!");
            }
            return valido;
        }
        public Circunferencia? GetCircunferencia()
        {
            return circFormulario;
        }

        public void SetCircunferencia(Circunferencia? circEditar)
        {
            circFormulario = circEditar;
        }
    }
}
