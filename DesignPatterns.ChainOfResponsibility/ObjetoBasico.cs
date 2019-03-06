using System;

public abstract class ObjetoBasico
{
    public ObjetoBasico siguiente { protected get; set; }

    private string descripcionPorDefecto()
    {
        return "descripción por defecto";
    }

    protected abstract string descripcion { get; }

    public string devuelveDescripcion()
    {
        string resultado;
        resultado = this.descripcion;
        if (resultado != null)
            return resultado;
        if (siguiente != null)
            return siguiente.devuelveDescripcion();
        else
            return this.descripcionPorDefecto();
    }
}
