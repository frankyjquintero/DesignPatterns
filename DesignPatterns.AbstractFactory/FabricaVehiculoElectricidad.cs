namespace DesignPatterns.AbstractFactory
{
    public class FabricaVehiculoElectricidad : IFabricaVehiculo
    {
        public virtual Automovil creaAutomovil(string modelo, string color, int potencia, double espacio)
        {
            return new AutomovilElectricidad(modelo, color, potencia, espacio);
        }

        public virtual Scooter creaScooter(string modelo, string color, int potencia)
        {
            return new ScooterElectricidad(modelo, color, potencia);
        }
    }

}
