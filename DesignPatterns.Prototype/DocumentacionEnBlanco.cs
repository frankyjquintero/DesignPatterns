using System.Collections.Generic;

public class DocumentacionEnBlanco : Documentacion
{
    private static DocumentacionEnBlanco _instance = null;

    private DocumentacionEnBlanco()
    {
        documentos = new List<Documento>();
    }

    public static DocumentacionEnBlanco Instance()
    {
        if (_instance == null)
            _instance = new DocumentacionEnBlanco();
        return _instance;
    }

    public void incluye(Documento doc)
    {
        documentos.Add(doc);
    }

    public void excluye(Documento doc)
    {
        documentos.Remove(doc);
    }
}
