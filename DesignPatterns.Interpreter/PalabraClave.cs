namespace DesignPatterns.Interpreter
{
    public class PalabraClave : Expresion
    {
        protected string palabraClave;

        public PalabraClave(string palabraClave)
        {
            this.palabraClave = palabraClave;
        }

        public override bool Evalua(string descripcion)
        {
            return descripcion.IndexOf(palabraClave) != -1;
        }

        // parte análisis sintáctico
        public static new Expresion Parsea()
        {
            Expresion resultado;
            resultado = new PalabraClave(pieza);
            SiguientePieza();
            return resultado;
        }
    }
}
