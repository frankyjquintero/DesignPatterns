namespace DesignPatterns.ReflectiveVisitor
{
    public interface IVisitanteEmpresa
    {
        void Visita(EmpresaSinFilial empresa);
        void Visita(EmpresaMadre empresa);
    }
}
