namespace DesignPatterns.ReflectiveVisitor
{
    public abstract class Empresa : IVisitable
    {
        public string Nombre { get; protected set; }
        public string Email { get; protected set; }
        public string Direccion { get; protected set; }

        public Empresa(string nombre, string email, string direccion)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Direccion = direccion;
        }

        public abstract bool AgregaFilial(Empresa filial);
    }
}
