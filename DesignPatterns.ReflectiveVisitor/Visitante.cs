using System;
using System.Reflection;

namespace DesignPatterns.ReflectiveVisitor
{
    public abstract class Visitante
    {
        public void IniciaVisita(IVisitable visitable)
        {
            MethodInfo infoMetodo = this.GetType().GetMethod("visita",
                new Type[] { visitable.GetType() });
            infoMetodo.Invoke(this, new object[] { visitable });
        }

        public void Visita(IVisitable visitable)
        {
            Console.WriteLine("Visita por defecto");
        }
    }
}