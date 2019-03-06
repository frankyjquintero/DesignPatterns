using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public abstract class Iterador<TElemento>
        where TElemento : Elemento
    {
        public string PalabraClaveConsulta { protected get; set; }
        protected int indice;
        public IList<TElemento> Contenido { protected get; set; }


        public void Inicio()
        {
            indice = 0;
            int tamaño = Contenido.Count;
            while ((indice < tamaño) &&
                   (!Contenido[indice].PalabraClaveValida(PalabraClaveConsulta)))
                indice++;
        }

        public void Siguiente()
        {
            int tamaño = Contenido.Count;
            indice++;
            while ((indice < tamaño) &&
                   (!Contenido[indice].PalabraClaveValida(PalabraClaveConsulta)))
                indice++;
        }

        public TElemento Item()
        {
            if (indice < Contenido.Count)
                return Contenido[indice];
            else
                return null;
        }
    }
}
