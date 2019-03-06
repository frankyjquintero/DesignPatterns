public abstract class FormularioMatriculacion
{
    protected string contenido;
    protected IFormularioImpl implementacion;

    public FormularioMatriculacion(IFormularioImpl
      implementacion)
    {
        this.implementacion = implementacion;
    }

    public void Visualiza()
    {
        implementacion.DibujaTexto(
        "número de matrícula existente: ");
    }

    public void GeneraDocumento()
    {
        implementacion.DibujaTexto("Solicitud de matriculación");
        implementacion.DibujaTexto("número de matrícula: " +
        contenido);
    }

    public bool AdministraZona()
    {
        contenido = implementacion.AdministraZonaIndicada();
        return ControlZona(contenido);
    }

    protected abstract bool ControlZona(string matricula);
}
