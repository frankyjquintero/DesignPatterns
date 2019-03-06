using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class MementoImpl : IMemento
    {
        protected IList<OpcionVehiculo> opciones =
            new List<OpcionVehiculo>();

        public IList<OpcionVehiculo> Estado
        {
            get
            {
                return opciones;
            }
            set
            {
                this.opciones.Clear();
                foreach (OpcionVehiculo opcion in value)
                    this.opciones.Add(opcion);
            }
        }
    }
}
