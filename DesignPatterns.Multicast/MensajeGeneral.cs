using System;
using System.Collections.Generic;

public class MensajeGeneral : MensajeAbstracto
{
    public IList<string> contenido { get; protected set; }

    public MensajeGeneral(IList<string> contenido)
    {
        this.contenido = contenido;
    }
}

