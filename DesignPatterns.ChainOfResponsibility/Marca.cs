namespace DesignPatterns.ChainOfResponsibility
{
    public class Marca : ObjetoBasico
    {
        protected string descripcion1, descripcion2;
        protected string nombre;

        public Marca(string nombre, string descripcion1, string
            descripcion2)
        {
            this.descripcion1 = descripcion1;
            this.descripcion2 = descripcion2;
            this.nombre = nombre;
        }


        protected override string Descripcion
        {
            get
            {
                if ((descripcion1 != null) && (descripcion2 != null))
                    return "Marca " + nombre + " : " + descripcion1 + " "
                           + descripcion2;
                else if (descripcion1 != null)
                    return "Marca " + nombre + " : " + descripcion1;
                else
                    return null;
            }
        }
    }
}
