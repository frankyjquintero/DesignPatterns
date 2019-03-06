using System.Collections.Generic;

namespace DesignPatterns.Mediator
{
    public class Formulario
    {
        protected IList<Control> controles =
            new List<Control>();
        protected IList<Control> controlesCoprestatario =
            new List<Control>();
        public PopupMenu MenuCoprestatario { protected get; set; }
        public Boton BotonOk { protected get; set; }
        protected bool enCurso = true;

        public void AgregaControl(Control control)
        {
            controles.Add(control);
            control.Director = this;
        }

        public void AgregaControlCoprestatario(Control
            control)
        {
            controlesCoprestatario.Add(control);
            control.Director = this;
        }

        public void ControlModificado(Control control)
        {
            if (control == MenuCoprestatario)
                if (control.Valor == "con coprestatario")
                {
                    foreach (Control elementoCoprestatario in
                        controlesCoprestatario)
                        elementoCoprestatario.Informa();
                }
            if (control == BotonOk)
            {
                enCurso = false;
            }
        }

        public void Informa()
        {
            while (true)
            {
                foreach (Control control in controles)
                {
                    control.Informa();
                    if (!enCurso)
                        return;
                }
            }
        }

    }
}
