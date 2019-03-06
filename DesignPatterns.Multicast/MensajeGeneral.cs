using System.Collections.Generic;

namespace DesignPatterns.Multicast
{
    public class MensajeGeneral : MensajeAbstracto
    {
        public IList<string> Contenido { get; protected set; }

        public MensajeGeneral(IList<string> contenido)
        {
            this.Contenido = contenido;
        }
    }
}

