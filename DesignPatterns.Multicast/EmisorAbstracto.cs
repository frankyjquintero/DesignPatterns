using System;
using System.Collections.Generic;

public abstract class EmisorAbstracto
 <TMensaje, TReceptor>
    where TMensaje : MensajeAbstracto
    where TReceptor : ReceptorAbstracto<TMensaje>
{
    protected IList<TReceptor> registro =
  new List<TReceptor>();

    public void agrega(TReceptor receptor)
    {
        registro.Add(receptor);
    }

    public void envioMultiple(TMensaje mensaje)
    {
        foreach (TReceptor receptor in registro)
            receptor.recibe(mensaje);
    }
}

