using System;

namespace DesignPatterns.Interpreter
{
    public static class Usuario
    {
        private static void Main(string[] args)
        {
            Expresion expresionConsulta = null;
            Console.Write("Introduzca su consulta: ");
            string consulta = Console.ReadLine();
            try
            {
                expresionConsulta = Expresion.Analiza(consulta);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                expresionConsulta = null;
            }
            if (expresionConsulta != null)
            {
                Console.WriteLine(
                    "Introduzca la descripción de un vehículo: ");
                string descripcion = Console.ReadLine();
                if (expresionConsulta.Evalua(descripcion))
                {
                    Console.WriteLine(
                        "La descripción responde a la consulta");
                }
                else
                {
                    Console.WriteLine(
                        "La descripción no responde a la consulta");
                }

                Console.ReadKey();
            }
        }
    }
}
