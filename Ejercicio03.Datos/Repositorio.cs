using Ejercicio03.Entidades;

namespace Ejercicio03.Datos
{
    public class Repositorio
    {
        private List<Punto> puntos;
        public Repositorio()
        {
            puntos= new List<Punto>();
            PopularLista();
        }

        private void PopularLista()
        {
            puntos.AddRange(new List<Punto>()
            {
                new Punto(1,1),
                new Punto(2,-2),
                new Punto(-3,-3),
                new Punto(-4,5)
            });
        }

        public void Agregar(Punto punto)
        {
            puntos.Add(punto);
        }
        public void Eliminar(Punto punto)
        {
            puntos.Remove(punto);
        }
        public int GetCantidad(Cuadrante? cuadrante=null){
            return cuadrante is null ? puntos.Count : puntos.Count(p => p.GetCuadrante() == cuadrante);
        }
        public List<Punto> GetLista()=> puntos;
        public bool EstaRepetido(int x, int y)
        {
            return puntos.Any(p=>p.X==x && p.Y==y);
        }

        public List<Punto>? Filtrar(Cuadrante cuadranteFiltro)
        {
            return puntos.Where(p=>p.GetCuadrante()==cuadranteFiltro).ToList();
        }
    }
}
