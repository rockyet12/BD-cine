using System.Diagnostics;

public class Genero
{
    public  Guid IdGenero { get; set; }
    public string Nombre { get; set; }
    public Genero(Guid IdGenero, string nombre)
    {
        this.IdGenero = IdGenero;
        this.Nombre=nombre;
    }
}