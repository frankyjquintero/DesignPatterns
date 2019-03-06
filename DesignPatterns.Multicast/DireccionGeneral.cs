using System;
using System.Collections.Generic;

public class DireccionGeneral
{
    protected EmisorGeneral emisorGeneral = new
  EmisorGeneral();

    public void enviaMensajes()
    {
        IList<string> contenido = new List<string>();
        contenido.Add("Información general");
        contenido.Add("Información específica");
        MensajeGeneral mensaje = new MensajeGeneral(contenido);
        emisorGeneral.envioMultiple(mensaje);
    }

    public void agregaReceptorGeneral(Empleado receptor)
    {
        emisorGeneral.agrega(receptor);
    }
}

