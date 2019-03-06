using System;

public class ServidorWeb
{
  static void Main(string[] args)
  {
    Documento documento1, documento2;
    documento1 = new DocumentoHtml();
    documento1.contenido = "Hello";
    documento1.dibuja();
    Console.WriteLine();
    documento2 = new DocumentoPdf();
    documento2.contenido = "Hola";
    documento2.dibuja();
  }
}
