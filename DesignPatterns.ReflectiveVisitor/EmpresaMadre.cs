using System.Collections.Generic;

namespace DesignPatterns.ReflectiveVisitor
{
    public class EmpresaMadre : Empresa
    {
        public IList<Empresa> Filiales { get; protected set; }

        public EmpresaMadre(string nombre, string email, string
            direccion)
            : base(nombre, email, direccion)
        {
            Filiales = new List<Empresa>();
        }

        public override bool AgregaFilial(Empresa filial)
        {
            Filiales.Add(filial);
            return true;
        }
    }
}
