namespace DesignPatterns.Visitor
{
    public interface IVisitante
    {
        void Visita(EmpresaSinFilial empresa);
        void Visita(EmpresaMadre empresa);
    }
}
