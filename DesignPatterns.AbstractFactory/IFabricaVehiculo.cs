namespace DesignPatterns.AbstractFactory
{
    public interface IFabricaVehiculo
    {
        Automovil creaAutomovil(string modelo, string color, int potencia, double espacio);

        Scooter creaScooter(string modelo, string color, int potencia);
    }

}
