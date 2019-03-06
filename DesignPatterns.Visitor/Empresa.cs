using System;

public abstract class Empresa
{
    public string nombre { get; protected set; }
    public string email { get; protected set; }
    public string direccion { get; protected set; }

    public Empresa(string nombre, string email, string direccion)
    {
        this.nombre = nombre;
        this.email = email;
        this.direccion = direccion;
    }

    public abstract bool agregaFilial(Empresa filial);

    public abstract void aceptaVisitante(Visitante visitante);
}
