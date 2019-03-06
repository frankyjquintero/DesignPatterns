namespace DesignPatterns.Observer
{
    public class Vehiculo : Sujeto
    {
        private string _descripcion;
        private double _precio;

        public string Descripcion
        {
            get => _descripcion;
            set
            {
                _descripcion = value;
                this.Notifica();
            }
        }

        public double Precio
        {
            get => _precio;
            set
            {
                _precio = value;
                this.Notifica();
            }
        }

    }
}
