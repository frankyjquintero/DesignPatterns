using System;

public class EmpresaSinFilial : Empresa
{
    public EmpresaSinFilial(string nombre, string email,
    string direccion)
        : base(nombre, email, direccion) { }

    public override void aceptaVisitante(Visitante visitante)
    {
        visitante.visita(this);
    }

    public override bool agregaFilial(Empresa filial)
    {
        return false;
    }
}
