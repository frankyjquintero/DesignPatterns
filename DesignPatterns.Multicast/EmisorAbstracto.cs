using System.Collections.Generic;

namespace DesignPatterns.Multicast
{
    public abstract class EmisorAbstracto
        <TMensaje, TReceptor>
        where TMensaje : MensajeAbstracto
        where TReceptor : IReceptorAbstracto<TMensaje>
    {
        protected IList<TReceptor> registro =
            new List<TReceptor>();

        public void Agrega(TReceptor receptor)
        {
            registro.Add(receptor);
        }

        public void EnvioMultiple(TMensaje mensaje)
        {
            foreach (TReceptor receptor in registro)
                receptor.Recibe(mensaje);
        }
    }
}

