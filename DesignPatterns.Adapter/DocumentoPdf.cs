public class DocumentoPdf : IDocumento
{
    protected ComponentePdf herramientaPdf = new ComponentePdf();

    public string Contenido
    {
        set => herramientaPdf.PdfFijaContenido(value);
    }

    public void Dibuja()
    {
        herramientaPdf.PdfPreparaVisualizacion();
        herramientaPdf.PdfRefresca();
        herramientaPdf.PdfFinalizaVisualizacion();
    }

    public void Imprime()
    {
        herramientaPdf.PdfEnviaImpresora();
    }
}
