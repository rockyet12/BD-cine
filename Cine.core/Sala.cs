namespace Biblioteca;

public class Sala
{
    public int IdSala { get; set; }
    public int Piso { get; set; }
    public ushort Capacidad { get; set; }
    public Sala (int idSala, int piso, ushort apacidad){
        IdSala = idSala;
        Piso = piso;
        Capacidad = capacidad;
    }
}
