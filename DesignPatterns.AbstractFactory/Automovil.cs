namespace DesignPatterns.AbstractFactory
{
    public abstract class Automovil
    {
        protected string modelo;
        protected string color;
        protected int potencia;
        protected double espacio;
        public Automovil(string modelo, string color, int
                         potencia, double espacio)
        {
            this.modelo = modelo;
            this.color = color;
            this.potencia = potencia;
            this.espacio = espacio;
        }
        public abstract void MostrarCaracteristicas();
    }



}
