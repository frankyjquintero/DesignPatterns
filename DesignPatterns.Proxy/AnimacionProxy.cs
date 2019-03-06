using System;

public class AnimacionProxy : Animacion
{
    protected Video video = null;
    protected string foto = "mostrar la foto";

    public void clic()
    {
        if (video == null)
        {
            video = new Video();
            video.carga();
        }
        video.reproduce();
    }

    public void dibuja()
    {
        if (video != null)
            video.dibuja();
        else
            dibuja(foto);
    }

    public void dibuja(string foto)
    {
        Console.WriteLine(foto);
    }
}
