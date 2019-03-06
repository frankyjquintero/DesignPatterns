public class MensajeComercial : MensajeAbstracto
{
    public string contenido { get; protected set; }

    public MensajeComercial(string contenido)
    {
        this.contenido = contenido;
    }
}

