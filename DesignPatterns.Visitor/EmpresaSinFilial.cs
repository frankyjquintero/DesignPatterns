namespace DesignPatterns.Visitor
{
    public class EmpresaSinFilial : Empresa
    {
        public EmpresaSinFilial(string nombre, string email,
            string direccion)
            : base(nombre, email, direccion) { }

        public override void AceptaVisitante(IVisitante visitante)
        {
            visitante.Visita(this);
        }

        public override bool AgregaFilial(Empresa filial)
        {
            return false;
        }
    }
}
