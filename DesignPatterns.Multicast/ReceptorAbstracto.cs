public interface ReceptorAbstracto<TMensaje>
 where TMensaje : MensajeAbstracto
{
    void recibe(TMensaje mensaje);
}

