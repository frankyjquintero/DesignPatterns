public class FormularioMatriculacionEspaña :
  FormularioMatriculacion
{
    public FormularioMatriculacionEspaña(IFormularioImpl
    implementacion) : base(implementacion) { }

    protected override bool ControlZona(string matricula)
    {
        return matricula.Length == 7;
    }
}
