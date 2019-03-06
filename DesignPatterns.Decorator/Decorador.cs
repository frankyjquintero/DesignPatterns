namespace DesignPatterns.Decorator
{
    public abstract class Decorador :
        IComponenteGraficoVehiculo
    {
        protected IComponenteGraficoVehiculo componente;

        public Decorador(IComponenteGraficoVehiculo componente)
        {
            this.componente = componente;
        }

        public virtual void Visualiza()
        {
            componente.Visualiza();
        }
    }
}
