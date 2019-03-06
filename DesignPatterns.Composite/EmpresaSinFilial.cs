namespace DesignPatterns.Composite
{
    public class EmpresaSinFilial : Empresa
    {
        public override bool AgregaFilial(Empresa filial)
        {
            return false;
        }

        public override double CalculaCosteMantenimiento()
        {
            return nVehiculos * costeUnitarioVehiculo;
        }
    }
}
