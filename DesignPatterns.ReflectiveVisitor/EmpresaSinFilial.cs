using System;

public class EmpresaSinFilial : Empresa
{
    public EmpresaSinFilial(string nombre, string email,
     string direccion)
        : base(nombre, email, direccion) { }

    public override bool agregaFilial(Empresa filiale)
    {
        return false;
    }
}
