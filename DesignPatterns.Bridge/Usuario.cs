using System;

namespace DesignPatterns.Bridge
{
    public static class Usuario
    {
        private static void Main(string[] args)
        {
            FormularioMatriculacionPortugal formulario1 = new
                FormularioMatriculacionPortugal(new FormHtmlImpl());
            formulario1.Visualiza();
            if (formulario1.AdministraZona())
            {
                formulario1.GeneraDocumento();
            }

            Console.WriteLine();
            FormularioMatriculacionEspaņa formulario2 = new
                FormularioMatriculacionEspaņa(new FormAppletImpl());
            formulario2.Visualiza();
            if (formulario2.AdministraZona())
            {
                formulario2.GeneraDocumento();
            }

            Console.ReadKey();
        }
    }
}
