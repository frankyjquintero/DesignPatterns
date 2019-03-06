namespace DesignPatterns.FactoryMethod
{
    public abstract class Pedido
    {
        protected double importe;

        public Pedido(double importe)
        {
            this.importe = importe;
        }

        public abstract bool Valida();

        public abstract void Paga();
    }
}
