using System;

public abstract class FormularioMatriculacion
{
    protected string contenido;
    protected FormularioImpl implementacion;

    public FormularioMatriculacion(FormularioImpl
      implementacion)
    {
        this.implementacion = implementacion;
    }

    public void visualiza()
    {
        implementacion.dibujaTexto(
        "número de matrícula existente: ");
    }

    public void generaDocumento()
    {
        implementacion.dibujaTexto("Solicitud de matriculación");
        implementacion.dibujaTexto("número de matrícula: " +
        contenido);
    }

    public bool administraZona()
    {
        contenido = implementacion.administraZonaIndicada();
        return this.controlZona(contenido);
    }

    protected abstract bool controlZona(string matricula);
}
