using System;
using System.Collections.Generic;

public class EmpresaMadre : Empresa
{
    protected IList<Empresa> filiales =
      new List<Empresa>();

    public override bool agregaFilial(Empresa filial)
    {
        filiales.Add(filial);
        return true;
    }

    public override double calculaCosteMantenimiento()
    {
        double cout = 0.0;
        foreach (Empresa filial in filiales)
            cout = cout + filial.calculaCosteMantenimiento();
        return cout + nVehiculos * costeUnitarioVehiculo;
    }
}
