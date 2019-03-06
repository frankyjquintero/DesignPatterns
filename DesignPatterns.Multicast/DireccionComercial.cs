namespace DesignPatterns.Multicast
{
    public class DireccionComercial
    {
        protected EmisorComercial emisorComercial =
            new EmisorComercial();

        public void EnviaMensajes()
        {
            MensajeComercial mensaje = new MensajeComercial(
                "Anuncio nueva gama");
            emisorComercial.EnvioMultiple(mensaje);
            mensaje = new MensajeComercial(
                "Anuncio supresión modelo");
            emisorComercial.EnvioMultiple(mensaje);
        }

        public void AgregaReceptorComercial
            (IReceptorComercial receptor)
        {
            emisorComercial.Agrega(receptor);
        }
    }
}

