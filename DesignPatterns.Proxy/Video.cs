using System;

public class Video : Animacion
{
    public void clic() { }

    public void dibuja()
    {
        Console.WriteLine("Mostrar el vídeo");
    }

    public void carga()
    {
        Console.WriteLine("Cargar el vídeo");
    }

    public void reproduce()
    {
        Console.WriteLine("Reproducir el vídeo");
    }
}
