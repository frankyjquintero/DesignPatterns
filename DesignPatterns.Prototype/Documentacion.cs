using System.Collections.Generic;

namespace DesignPatterns.Prototype
{
    public abstract class Documentacion
    {
        public IList<Documento> Documentos { get; protected set; }
    }
}
