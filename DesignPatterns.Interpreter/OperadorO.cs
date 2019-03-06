namespace DesignPatterns.Interpreter
{
    public class OperadorO : OperadorBinario
    {
        public OperadorO(Expresion operandoIzquierdo,
            Expresion operandoDerecho)
            : base(operandoIzquierdo,
                operandoDerecho) { }

        public override bool Evalua(string descripcion)
        {
            return operandoIzquierdo.Evalua(descripcion) ||
                   operandoDerecho.Evalua(descripcion);
        }

        // parte análisis sintáctico
        public static new Expresion Parsea()
        {
            Expresion resultadoIzquierdo, resultadoDerecho;
            resultadoIzquierdo = OperadorY.Parsea();
            while ((pieza != null) && (pieza == "o"))
            {
                SiguientePieza();
                resultadoDerecho = OperadorY.Parsea();
                resultadoIzquierdo = new OperadorO(resultadoIzquierdo,
                    resultadoDerecho);
            }
            return resultadoIzquierdo;
        }
    }
}
