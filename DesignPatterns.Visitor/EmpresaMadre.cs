using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    public class EmpresaMadre : Empresa
    {
        protected IList<Empresa> filiales =
            new List<Empresa>();

        public EmpresaMadre(string nombre, string email, string
            direccion)
            : base(nombre, email, direccion) { }

        public override void AceptaVisitante(IVisitante visitante)
        {
            visitante.Visita(this);
            foreach (Empresa filial in filiales)
                filial.AceptaVisitante(visitante);
        }

        public override bool AgregaFilial(Empresa filial)
        {
            filiales.Add(filial);
            return true;
        }
    }
}
