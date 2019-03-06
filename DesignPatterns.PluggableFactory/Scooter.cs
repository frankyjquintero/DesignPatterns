namespace DesignPatterns.PluggableFactory
{
    public abstract class Scooter
    {
        public string Modelo { get; set; }
        public string Color { get; set; }
        protected int Potencia { get; set; }

        public Scooter Duplica()
        {
            Scooter resultado;
            resultado = (Scooter)this.MemberwiseClone();
            return resultado;
        }

        public abstract void VisualizaCaracteristicas();
    }
}

