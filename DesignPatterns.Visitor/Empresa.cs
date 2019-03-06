namespace DesignPatterns.Visitor
{
    public abstract class Empresa
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

        public abstract void AceptaVisitante(IVisitante visitante);
    }
}
