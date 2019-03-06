using System;

namespace DesignPatterns.Interpreter
{
    public abstract class Expresion
    {
        public abstract bool Evalua(string descripcion);

        // parte análisis sintáctico
        protected static string fuente;
        protected static int indice;
        protected static string pieza;

        protected static void SiguientePieza()
        {
            while ((indice < fuente.Length) && (fuente[indice] ==
                                                ' '))
                indice++;
            if (indice == fuente.Length)
                pieza = null;
            else if ((fuente[indice] == '(') || (fuente[indice] ==
                                                 ')'))
            {
                pieza = fuente.Substring(indice, 1);
                indice++;
            }
            else
            {
                int inicio = indice;
                while ((indice < fuente.Length) && (fuente[indice] !=
                                                    ' ') && (fuente[indice] != ')'))
                    indice++;
                pieza = fuente.Substring(inicio, indice - inicio);
            }
        }

        public static Expresion Analiza(string fuente)
        {
            Expresion.fuente = fuente;
            indice = 0;
            SiguientePieza();
            return OperadorO.Parsea();
        }

        public static Expresion Parsea()
        {
            Expresion resultado;
            if (pieza == "(")
            {
                SiguientePieza();
                resultado = OperadorO.Parsea();
                if (pieza == null)
                    throw new Exception("Error de sintaxis");
                if (pieza != ")")
                    throw new Exception("Error de sintaxis");
                SiguientePieza();
            }
            else
                resultado = PalabraClave.Parsea();
            return resultado;
        }
    }
}
