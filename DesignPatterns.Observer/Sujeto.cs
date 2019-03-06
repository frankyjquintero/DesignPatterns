using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public abstract class Sujeto
    {
        protected IList<IObservador> observadores =
            new List<IObservador>();

        public void Agrega(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void Suprime(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void Notifica()
        {
            foreach (IObservador observador in observadores)
                observador.Actualiza();
        }
    }
}
