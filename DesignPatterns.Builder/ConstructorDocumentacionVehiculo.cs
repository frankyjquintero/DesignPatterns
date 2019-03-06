namespace DesignPatterns.Builder
{
    public abstract class ConstructorDocumentacionVehiculo
    {
        protected Documentacion documentacion;

        public abstract void ConstruyeSolicitudPedido(string
            nombreCliente);

        public abstract void ConstruyeSolicitudMatriculacion
            (string nombreSolicitante);

        public Documentacion Resultado()
        {
            return documentacion;
        }
    }
}
