using Ejercicio01.Entidades;

namespace Ejercicio01.Datos
{
    public class Repositorio
    {
        //atributo privado
        private List<Circunferencia> listaCircunferencias = null!;
        public Repositorio()
        {
            listaCircunferencias = new List<Circunferencia>();
            LoadData();
        }
        public bool Existe(Circunferencia circunferencia)
        {
            return listaCircunferencias.Any(c=>c.Radio==circunferencia.Radio);
        }
        private void LoadData()
        {
            listaCircunferencias.Add(new Circunferencia(5));
            listaCircunferencias.Add(new Circunferencia(7));
            listaCircunferencias.Add(new Circunferencia(8));
       }

        public void Agregar(Circunferencia circunferencia)
        {
            listaCircunferencias.Add(circunferencia);
        }
        public List<Circunferencia> GetLista() => listaCircunferencias;
        public int GetCantidad()=>listaCircunferencias.Count;

        public void Borrar(Circunferencia? circBorrar)
        {
            listaCircunferencias.Remove(circBorrar!);
        }

        public bool ExisteRadio(int radio)
        {
            return listaCircunferencias.Any(c => c.Radio == radio);
        }
        public List<Circunferencia> GetListaFiltrada(int valorFiltro)
        {
            return listaCircunferencias
                .Where(c=>c.Radio>= valorFiltro)
                .ToList();
        }
    }
}
