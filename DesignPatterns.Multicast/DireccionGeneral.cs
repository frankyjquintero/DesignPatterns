using System.Collections.Generic;

namespace DesignPatterns.Multicast
{
    public class DireccionGeneral
    {
        protected EmisorGeneral emisorGeneral = new
            EmisorGeneral();

        public void EnviaMensajes()
        {
            IList<string> contenido = new List<string>();
            contenido.Add("Información general");
            contenido.Add("Información específica");
            MensajeGeneral mensaje = new MensajeGeneral(contenido);
            emisorGeneral.EnvioMultiple(mensaje);
        }

        public void AgregaReceptorGeneral(Empleado receptor)
        {
            emisorGeneral.Agrega(receptor);
        }
    }
}

