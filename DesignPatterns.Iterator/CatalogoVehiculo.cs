public class CatalogoVehiculo : Catalogo<Vehiculo,
  IteradorVehiculo>
{

    public CatalogoVehiculo()
    {
        contenido.Add(new Vehiculo("vehículo económino"));
        contenido.Add(new Vehiculo("pequeño vehículo económico"));
        contenido.Add(new Vehiculo("vehículo de gran calidad"));
    }
}
