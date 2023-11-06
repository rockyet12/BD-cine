namespace Biblioteca;

public class Sala
{
    public Guid IdSala { get; set; }
    public int Piso { get; set; }
    public ushort Capacidad { get; set; }
    public Sala (Guid idSala, int piso, ushort apacidad){
        IdSala = idSala;
        Piso = piso;
        Capacidad = capacidad;
    }
}
