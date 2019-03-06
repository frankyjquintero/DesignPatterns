using System.Collections.Generic;
using System;

public class Formulario
{
    protected IList<Control> controles =
      new List<Control>();
    protected IList<Control> controlesCoprestatario =
      new List<Control>();
    public PopupMenu menuCoprestatario { protected get; set; }
    public Boton botonOK { protected get; set; }
    protected bool enCurso = true;

    public void agregaControl(Control control)
    {
        controles.Add(control);
        control.director = this;
    }

    public void agregaControlCoprestatario(Control
      control)
    {
        controlesCoprestatario.Add(control);
        control.director = this;
    }

    public void controlModificado(Control control)
    {
        if (control == menuCoprestatario)
            if (control.valor == "con coprestatario")
            {
                foreach (Control elementoCoprestatario in
               controlesCoprestatario)
                    elementoCoprestatario.informa();
            }
        if (control == botonOK)
        {
            enCurso = false;
        }
    }

    public void informa()
    {
        while (true)
        {
            foreach (Control control in controles)
            {
                control.informa();
                if (!enCurso)
                    return;
            }
        }
    }

}
