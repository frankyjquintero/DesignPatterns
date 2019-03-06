using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class EmpresaMadre : Empresa
    {
        protected IList<Empresa> filiales =
            new List<Empresa>();

        public override bool AgregaFilial(Empresa filial)
        {
            filiales.Add(filial);
            return true;
        }

        public override double CalculaCosteMantenimiento()
        {
            double cout = 0.0;
            foreach (Empresa filial in filiales)
            {
                cout = cout + filial.CalculaCosteMantenimiento();
            }

            return cout + nVehiculos * costeUnitarioVehiculo;
        }
    }
}
