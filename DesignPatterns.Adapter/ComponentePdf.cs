using System;

public class ComponentePdf
{
  protected string contenido;

  public void pdfFijaContenido(string contenido)
  {
    this.contenido = contenido;
  }

  public void pdfPreparaVisualizacion()
  {
    Console.WriteLine("Visualiza PDF: Comienzo");
  }

  public void pdfRefresca()
  {
    Console.WriteLine("Visualiza contenido PDF: " +
      contenido);
  }

  public void pdfFinalizaVisualizacion()
  {
    Console.WriteLine("Visualiza PDF: Fin");
  }

  public void pdfEnviaImpresora()
  {
    Console.WriteLine("Impresión PDF: " + contenido);
  }
}
