namespace Ejercicio03.Entidades
{
    public class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Punto()
        {

        }
        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public double GetDistanciaAlOrigen() => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        public Cuadrante GetCuadrante()
        {
            if (X >= 0 && Y >= 0)
            {
                return Cuadrante.Primer;
            }
            else if (X < 0 && Y >= 0)
            {
                return Cuadrante.Segundo;
            }
            else if (Y < 0 && X < 0)
            {
                return Cuadrante.Tercero;
            }
            else
            {
                return Cuadrante.Cuarto;
            }
        }
    }
}
