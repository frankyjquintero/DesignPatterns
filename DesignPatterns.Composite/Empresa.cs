namespace DesignPatterns.Composite
{
    public abstract class Empresa
    {
        protected static double costeUnitarioVehiculo = 5.0;
        protected int nVehiculos;

        public void AgregaVehiculo()
        {
            nVehiculos = nVehiculos + 1;
        }

        public abstract double CalculaCosteMantenimiento();

        public abstract bool AgregaFilial(Empresa filial);
    }
}
