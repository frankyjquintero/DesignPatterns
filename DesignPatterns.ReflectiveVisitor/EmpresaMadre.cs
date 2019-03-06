using System;
using System.Collections.Generic;

public class EmpresaMadre : Empresa
{
    public IList<Empresa> filiales { get; protected set; }

    public EmpresaMadre(string nombre, string email, string
     direccion)
        : base(nombre, email, direccion)
    {
        filiales = new List<Empresa>();
    }

    public override bool agregaFilial(Empresa filial)
    {
        filiales.Add(filial);
        return true;
    }
}
