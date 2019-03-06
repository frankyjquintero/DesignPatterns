using System;

namespace DesignPatterns.Decorator
{
    public class MarcaDecorador : Decorador
    {
        public MarcaDecorador(IComponenteGraficoVehiculo
            componente)
            : base(componente) { }

        protected void VisualizaLogo()
        {
            Console.WriteLine("Logotipo de la marca");
        }

        public override void Visualiza()
        {
            base.Visualiza();
            this.VisualizaLogo();
        }
    }
}
