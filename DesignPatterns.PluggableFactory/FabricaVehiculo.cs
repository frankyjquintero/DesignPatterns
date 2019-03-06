namespace DesignPatterns.PluggableFactory
{
    public class FabricaVehiculo
    {
        public Automovil PrototypeAutomovil { get; set; }
        public Scooter PrototypeScooter { get; set; }

        public FabricaVehiculo()
        {
            PrototypeAutomovil = null;
            PrototypeScooter = null;
        }

        public FabricaVehiculo(Automovil prototypeAutomovil,
            Scooter prototypeScooter)
        {
            this.PrototypeAutomovil = prototypeAutomovil;
            this.PrototypeScooter = prototypeScooter;
        }

        public Automovil CreaAutomovil()
        {
            if (PrototypeAutomovil == null)
                return null;
            return PrototypeAutomovil.Duplica();
        }

        public Scooter CreaScooter()
        {
            if (PrototypeScooter == null)
                return null;
            return PrototypeScooter.Duplica();
        }
    }
}

