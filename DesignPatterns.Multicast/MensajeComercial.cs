namespace DesignPatterns.Multicast
{
    public class MensajeComercial : MensajeAbstracto
    {
        public string Contenido { get; protected set; }

        public MensajeComercial(string contenido)
        {
            this.Contenido = contenido;
        }
    }
}

