namespace DesignPatterns.ReflectiveVisitor
{
    public class EmpresaSinFilial : Empresa
    {
        public EmpresaSinFilial(string nombre, string email,
            string direccion)
            : base(nombre, email, direccion) { }

        public override bool AgregaFilial(Empresa filiale)
        {
            return false;
        }
    }
}
