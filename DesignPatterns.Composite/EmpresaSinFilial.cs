using System;

public class EmpresaSinFilial : Empresa
{
    public override bool agregaFilial(Empresa filial)
    {
        return false;
    }

    public override double calculaCosteMantenimiento()
    {
        return nVehiculos * costeUnitarioVehiculo;
    }
}
