namespace DesignPatterns.ChainOfResponsibility
{
    public class Vehiculo : ObjetoBasico
    {
        protected string laDescripcion;

        public Vehiculo(string descripcion)
        {
            this.laDescripcion = descripcion;
        }

        protected override string Descripcion
        {
            get
            {
                return laDescripcion;
            }
        }
    }
}
