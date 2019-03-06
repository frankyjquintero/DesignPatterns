namespace DesignPatterns.Adapter
{
    public interface IDocumento
    {
        string Contenido { set; }
        void Dibuja();
        void Imprime();

    }
}
