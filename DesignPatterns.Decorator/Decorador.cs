public abstract class Decorador :
  ComponenteGraficoVehiculo
{
    protected ComponenteGraficoVehiculo componente;

    public Decorador(ComponenteGraficoVehiculo componente)
    {
        this.componente = componente;
    }

    public virtual void visualiza()
    {
        componente.visualiza();
    }
}
