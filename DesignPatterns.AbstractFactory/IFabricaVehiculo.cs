namespace DesignPatterns.AbstractFactory
{
    public interface IFabricaVehiculo
    {
        Automovil CreaAutomovil(string modelo, string color, int potencia, double espacio);

        Scooter CreaScooter(string modelo, string color, int potencia);
    }

}
