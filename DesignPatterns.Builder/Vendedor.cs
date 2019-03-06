namespace DesignPatterns.Builder
{
    public class Vendedor
    {
        protected ConstructorDocumentacionVehiculo constructor;

        public Vendedor(ConstructorDocumentacionVehiculo constructor)
        {
            this.constructor = constructor;
        }

        public Documentacion Construye(string nombreCliente)
        {
            constructor.ConstruyeSolicitudPedido(nombreCliente);
            constructor.ConstruyeSolicitudMatriculacion
                (nombreCliente);
            Documentacion documentacion = constructor.Resultado();
            return documentacion;
        }
    }
}
