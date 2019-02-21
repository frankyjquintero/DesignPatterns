using System;

namespace DesignPatterns.AbstractFactory
{
    internal class Program
    {
        ////public static void Main(string[] args)
        ////{
        ////    Console.WriteLine("Carro Electrico \n");
        ////    AutomovilElectricidad Leaf = new AutomovilElectricidad("Leaf", "Blanco", 90, 14.5);
        ////    Leaf.mostrarCaracteristicas();
        ////    Console.WriteLine("Carro Gasolina \n");
        ////    AutomovilGasolina Mustang = new AutomovilGasolina("Mustang", "Negro", 240, 14.5);
        ////    Mustang.mostrarCaracteristicas();
        ////}
   
        public static int nAutos = 3;
        public static int nScooters = 2;

        public static void Main(string[] args)
        {
            IFabricaVehiculo fabrica;
            Automovil[] autos = new Automovil[nAutos];
            Scooter[] scooters = new Scooter[nScooters];
            Console.Write("Desea utilizar " + "vehiculos electricos (1) o a gasolina (2):");
            string eleccion = Console.Read().ToString();
            if (eleccion.Equals("1"))
            {
                fabrica = new FabricaVehiculoElectricidad();

            }
            else
            {
                fabrica = new FabricaVehiculoGasolina();
            }
            for (int index = 0; index < nAutos; index++)
            {
                autos[index] = fabrica.creaAutomovil("estandar", "amarillo", 6 + index, 3.2);
            }
            for (int index = 0; index < nScooters; index++)
            {
                scooters[index] = fabrica.creaScooter("clasico", "rojo", 2 + index);
            }
            foreach (Automovil auto in autos)
            {
                auto.mostrarCaracteristicas();
            }
            foreach (Scooter scooter in scooters)
            {
                scooter.mostrarCaracteristicas();
            }
        }
    }

}
