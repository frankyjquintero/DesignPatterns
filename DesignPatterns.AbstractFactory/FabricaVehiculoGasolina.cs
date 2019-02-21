namespace DesignPatterns.AbstractFactory
{
    public class FabricaVehiculoGasolina : IFabricaVehiculo
    {
        public virtual Automovil CreaAutomovil(string modelo, string color, int potencia, double espacio)
        {
            return new AutomovilGasolina(modelo, color, potencia, espacio);
        }

        public virtual Scooter CreaScooter(string modelo, string color, int potencia)
        {
            return new ScooterGasolina(modelo, color, potencia);
        }
    }

}
