using System.Diagnostics;

public class Genero
{
    public  short IdGenero { get; set; }
    public string Nombre { get; set; }
    public Genero(short IdGenero, string nombre)
    {
        this.IdGenero = IdGenero;
        this.Nombre=nombre;
    }
}