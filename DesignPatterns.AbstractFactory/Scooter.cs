namespace DesignPatterns.AbstractFactory
{
    public abstract class Scooter
    {
        protected internal string modelo;
        protected internal string color;
        protected internal int potencia;

        public Scooter(string modelo, string color, int potencia)
        {
            this.modelo = modelo;
            this.color = color;
            this.potencia = potencia;
        }
        public abstract void MostrarCaracteristicas();
    }


}
