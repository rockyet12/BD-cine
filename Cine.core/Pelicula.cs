namespace Cine.Core;

public class Pelicula
{
    public ushort idpelicula { get; set; }
    public byte  idgenero { get; set; }
    public string nombre { get; set; }
    public DateTime lanzamiento { get; set; }
    public Pelicula(ushort idpelicula,byte idgenero, string nombre , DateTime lanzamiento)
    {
        this.idpelicula=idpelicula;
        this.idgenero=idgenero;
        this.nombre= nombre;
        this.lanzamiento=lanzamiento;
    }
}