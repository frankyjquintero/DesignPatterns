namespace DesignPatterns.AbstractFactory
{
    public class FabricaVehiculoElectricidad : IFabricaVehiculo
    {
        public virtual Automovil CreaAutomovil(string modelo, string color, int potencia, double espacio)
        {
            return new AutomovilElectricidad(modelo, color, potencia, espacio);
        }

        public virtual Scooter CreaScooter(string modelo, string color, int potencia)
        {
            return new ScooterElectricidad(modelo, color, potencia);
        }
    }

}
