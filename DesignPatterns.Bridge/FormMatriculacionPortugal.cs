public class FormularioMatriculacionPortugal :
  FormularioMatriculacion
{
    public FormularioMatriculacionPortugal(IFormularioImpl
    implementacion) : base(implementacion) { }

    protected override bool ControlZona(string matricula)
    {
        return matricula.Length == 6;
    }
}
