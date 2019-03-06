public class Usuario
{
    static void Main(string[] args)
    {
        Empresa empresa1 = new EmpresaSinFilial("empresa1",
         "info@empresa1.com", "calle de la empresa 1");
        Empresa empresa2 = new EmpresaSinFilial("empresa2",
         "info@empresa2.com", "calle de la empresa 2");
        Empresa grupo1 = new EmpresaMadre("grupo1",
         "info@grupo1.com", "calle del grupo 1");
        grupo1.agregaFilial(empresa1);
        grupo1.agregaFilial(empresa2);
        Empresa empresa3 = new EmpresaSinFilial("empresa3",
         "info@empresa3.com", "calle de la empresa 3");
        Empresa grupo2 = new EmpresaMadre("grupo2",
         "info@grupo2.com", "calle del grupo 2");
        grupo2.agregaFilial(grupo1);
        grupo2.agregaFilial(empresa3);
        new VisitanteMailingComercial().iniciaVisita(grupo2);
    }
}
