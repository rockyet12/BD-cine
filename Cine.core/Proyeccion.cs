namespace Biblioteca;

public class Proyeccion
{
    public int IdProyeccion { get; set; } 
    public List<Pelicula>IdPelicula = new();
    public List<Sala> IdSala = new();
    public DateTime Fechahora { get; set; }
    public Proyeccion(int idProyeccion,DateTime fechahora)
    {
        IdProyeccion = idProyeccion;
        IdPelicula = new List<Pelicula>();
        IdSala = new List<Sala>();
        Fechahora=fechahora;
    }
}
