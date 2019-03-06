using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public abstract class Catalogo<TElemento, TIterador>
        where TElemento : Elemento
        where TIterador : Iterador<TElemento>, new()
    {
        protected IList<TElemento> contenido =
            new List<TElemento>();

        public TIterador Busqueda(string palabraClaveConsulta)
        {
            TIterador resultado = new TIterador();
            resultado.PalabraClaveConsulta = palabraClaveConsulta;
            resultado.Contenido = contenido;
            return resultado;
        }
    }
}
