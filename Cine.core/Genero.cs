namespace Cine.Core;

public class Genero
{
    public byte idgenero { get; set; }
    public string  nombre{ get; set; }
    public Genero(byte  idgenero, string nombre)
    {
        this.idgenero=idgenero;
        this.nombre=nombre;
    }
}
