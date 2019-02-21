using System;

public class SolicitudMatriculacion : Documento
{
  public override void visualiza()
  {
    Console.WriteLine(
      "Muestra la solicitud de matriculación: " + contenido);
  }

  public override void imprime()
  {
    Console.WriteLine(
      "Imprime la solicitud de matriculación: " + contenido);
  }
}
