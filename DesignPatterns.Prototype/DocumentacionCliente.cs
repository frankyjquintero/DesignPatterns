using System.Collections.Generic;

namespace DesignPatterns.Prototype
{
    public class DocumentacionCliente : Documentacion
    {
        public DocumentacionCliente(string informacion)
        {
            Documentos = new List<Documento>();
            DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
            IList<Documento> documentosEnBlanco =
                documentacionEnBlanco.Documentos;
            foreach (Documento documento in documentosEnBlanco)
            {
                Documento copiaDocumento = documento.Duplica();
                copiaDocumento.Rellena(informacion);
                Documentos.Add(copiaDocumento);
            }
        }

        public void Visualiza()
        {
            foreach (Documento documento in Documentos)
                documento.Visualiza();
        }

        public void Imprime()
        {
            foreach (Documento documento in Documentos)
                documento.Imprime();
        }
    }
}
