using System;

public class Usuario
{
    static void Main(string[] args)
    {
        Empresa empresa1 = new EmpresaSinFilial();
        empresa1.agregaVehiculo();
        Empresa empresa2 = new EmpresaSinFilial();
        empresa2.agregaVehiculo();
        empresa2.agregaVehiculo();
        Empresa grupo = new EmpresaMadre();
        grupo.agregaFilial(empresa1);
        grupo.agregaFilial(empresa2);
        grupo.agregaVehiculo();
        Console.WriteLine(
          "Coste de mantenimiento total del grupo: " +
          grupo.calculaCosteMantenimiento());
    }
}
