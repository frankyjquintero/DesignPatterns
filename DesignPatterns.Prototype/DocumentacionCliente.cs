using System;
using System.Collections.Generic;

public class DocumentacionCliente : Documentacion
{
    public DocumentacionCliente(string informacion)
    {
        documentos = new List<Documento>();
        DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
        IList<Documento> documentosEnBlanco =
          documentacionEnBlanco.documentos;
        foreach (Documento documento in documentosEnBlanco)
        {
            Documento copiaDocumento = documento.duplica();
            copiaDocumento.rellena(informacion);
            documentos.Add(copiaDocumento);
        }
    }

    public void visualiza()
    {
        foreach (Documento documento in documentos)
            documento.visualiza();
    }

    public void imprime()
    {
        foreach (Documento documento in documentos)
            documento.imprime();
    }
}
