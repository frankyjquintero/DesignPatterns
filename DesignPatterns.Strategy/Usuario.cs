using System;
public class Usuario
{
    static void Main(string[] args)
    {
        VistaCatalogo vistaCatalogo1 = new VistaCatalogo(new
        DibujaTresVehiculosPorLinea());
        vistaCatalogo1.dibuja();
        VistaCatalogo vistaCatalogo2 = new VistaCatalogo(new
        DibujaUnVehiculoPorLinea());
        vistaCatalogo2.dibuja();
    }
}
