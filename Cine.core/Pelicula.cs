namespace Biblioteca;

public class Pelicula
{
    public ushort IdPelicula { get; set; }
    public List<Genero>IdGenero = new List<Genero>();
    public string Nombre { get; set; }
    public DateOnly  Lanzamiento { get; set; }
    public Pelicula(ushort idPelicula, string nombre, DateOnly lanzamiento)
    {
        IdPelicula = idPelicula;
        IdGenero= new List<Genero>();
        Nombre = nombre;
        Lanzamiento = lanzamiento;
    }
}
