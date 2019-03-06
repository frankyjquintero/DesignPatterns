namespace DesignPatterns.Multicast
{
    public interface IReceptorAbstracto<TMensaje>
        where TMensaje : MensajeAbstracto
    {
        void Recibe(TMensaje mensaje);
    }
}

