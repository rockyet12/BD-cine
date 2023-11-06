namespace Cine.core;

public interface IAdo
{
    void AltaGenero(Genero genero);
    List<Genero>ObtenerGenero();
    void AltaPelicula(Pelicula pelicula); 
    List<Pelicula>ObtenerPelicula();
    Pelicula? ObtenerPelicula(ushort IdPelicula);
}
