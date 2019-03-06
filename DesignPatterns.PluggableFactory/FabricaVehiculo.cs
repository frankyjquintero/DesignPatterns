using System;

public class FabricaVehiculo
{
    public Automovil prototypeAutomovil { get; set; }
    public Scooter prototypeScooter { get; set; }

    public FabricaVehiculo()
    {
        prototypeAutomovil = null;
        prototypeScooter = null;
    }

    public FabricaVehiculo(Automovil prototypeAutomovil,
     Scooter prototypeScooter)
    {
        this.prototypeAutomovil = prototypeAutomovil;
        this.prototypeScooter = prototypeScooter;
    }

    public Automovil creaAutomovil()
    {
        if (prototypeAutomovil == null)
            return null;
        return prototypeAutomovil.duplica();
    }

    public Scooter creaScooter()
    {
        if (prototypeScooter == null)
            return null;
        return prototypeScooter.duplica();
    }
}

