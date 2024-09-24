namespace Ejercicio01.Entidades
{
    public class Circunferencia
    {
        public int Radio { get; set; }
        public Circunferencia()
        {
            
        }
        public Circunferencia(int radio)
        {
            Radio= radio;   
        }
        public double GetPerimetro() => 2 * Math.PI * Radio;
        public double GetSuperficie()=>Math.PI*Math.Pow(Radio,2);

        public double GetDiametro() => 2 * Radio;
        public double GetLongArco() => Math.PI * GetDiametro();
    }
}
