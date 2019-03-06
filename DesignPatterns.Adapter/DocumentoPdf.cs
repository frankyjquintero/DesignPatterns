using System;

public class DocumentoPdf : Documento
{
  protected ComponentePdf herramientaPdf = new ComponentePdf();

  public string contenido
  {
     set
     {
       herramientaPdf.pdfFixeContenu(value);
     }
  }

  public void dibuja()
  {
    herramientaPdf.pdfPreparaVisualizacion();
    herramientaPdf.pdfRefresca();
    herramientaPdf.pdfFinalizaVisualizacion();
  }

  public void imprime()
  {
    herramientaPdf.pdfEnviaImpresora();
  }
}
