namespace DesignPatterns.PluggableFactory
{
    public abstract class Automovil
    {
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Potencia { get; set; }
        public double Espacio { get; set; }

        public Automovil Duplica()
        {
            Automovil resultado;
            resultado = (Automovil)this.MemberwiseClone();
            return resultado;
        }

        public abstract void VisualizaCaracteristicas();
    }
}


