namespace Cine.Core;

public class Proyeccion
{
    public int idproyeccion { get; set; }
    public int idsala { get; set; }
    public ushort idpelicula { get; set; }
    public DateTime fechahora { get; set; }

    public Proyeccion(int idproyeccion,int idsala, ushort idpelicula,DateTime fechahora )
    {
        this.idproyeccion=idproyeccion;
        this.idsala=idsala;
        this.idpelicula=idpelicula;
        this.fechahora=fechahora;
    }
}
