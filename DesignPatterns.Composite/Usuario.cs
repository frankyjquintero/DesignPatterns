using System;

namespace DesignPatterns.Composite
{
    public static class Usuario
    {
        private static void Main(string[] args)
        {
            Empresa empresa1 = new EmpresaSinFilial();
            empresa1.AgregaVehiculo();
            Empresa empresa2 = new EmpresaSinFilial();
            empresa2.AgregaVehiculo();
            empresa2.AgregaVehiculo();
            Empresa grupo = new EmpresaMadre();
            grupo.AgregaFilial(empresa1);
            grupo.AgregaFilial(empresa2);
            grupo.AgregaVehiculo();
            Console.WriteLine(
                "Coste de mantenimiento total del grupo: " +
                grupo.CalculaCosteMantenimiento());
            Console.ReadKey();
        }
    }
}
