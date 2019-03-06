namespace DesignPatterns.Iterator
{
    public abstract class Elemento
    {
        protected string descripcion;

        public Elemento(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public bool PalabraClaveValida(string palabraClave)
        {
            return descripcion.IndexOf(palabraClave) != -1;
        }
    }
}
