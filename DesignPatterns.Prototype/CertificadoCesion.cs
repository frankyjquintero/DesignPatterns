using System;

namespace DesignPatterns.Prototype
{
    public class CertificadoCesion : Documento
    {
        public override void Visualiza()
        {
            Console.WriteLine(
                "Muestra el certificado de cesión: " + contenido);
        }

        public override void Imprime()
        {
            Console.WriteLine(
                "Imprime el certificado de cesión: " + contenido);
        }
    }
}
