using System;
using System.Collections.Generic;

public class EmpresaMadre : Empresa
{
    protected IList<Empresa> filiales =
        new List<Empresa>();

    public EmpresaMadre(string nombre, string email, string
      direccion)
        : base(nombre, email, direccion) { }

    public override void aceptaVisitante(Visitante visitante)
    {
        visitante.visita(this);
        foreach (Empresa filial in filiales)
            filial.aceptaVisitante(visitante);
    }

    public override bool agregaFilial(Empresa filial)
  {
    filiales.Add(filial);
    return true;
  }
}
