using System;

public class Usuario
{
    static void Main(string[] args)
    {
        FormularioMatriculacionPortugal formulario1 = new
          FormularioMatriculacionPortugal(new FormHtmlImpl());
        formulario1.visualiza();
        if (formulario1.administraZona())
            formulario1.generaDocumento();
        Console.WriteLine();
        FormularioMatriculacionEspaña formulario2 = new
          FormularioMatriculacionEspaña(new FormAppletImpl());
        formulario2.visualiza();
        if (formulario2.administraZona())
            formulario2.generaDocumento();
    }
}
