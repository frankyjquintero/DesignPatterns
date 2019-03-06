namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class ObjetoBasico
    {
        public ObjetoBasico Siguiente { protected get; set; }

        private string DescripcionPorDefecto()
        {
            return "descripción por defecto";
        }

        protected abstract string Descripcion { get; }

        public string DevuelveDescripcion()
        {
            string resultado;
            resultado = this.Descripcion;
            if (resultado != null)
                return resultado;
            if (Siguiente != null)
                return Siguiente.DevuelveDescripcion();
            else
                return this.DescripcionPorDefecto();
        }
    }
}
