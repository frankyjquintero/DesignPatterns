namespace DesignPatterns.AbstractFactory
{
    public class FabricaVehiculoGasolina : IFabricaVehiculo
    {
        public virtual Automovil creaAutomovil(string modelo, string color, int potencia, double espacio)
        {
            return new AutomovilGasolina(modelo, color, potencia, espacio);
        }

        public virtual Scooter creaScooter(string modelo, string color, int potencia)
        {
            return new ScooterGasolina(modelo, color, potencia);
        }
    }

}
