namespace Cine.Core;

public class Sala
{
    public byte idsala { get; set; }
    public byte piso { get; set; }
    public ushort capacidad { get; set; }

    public Sala(byte idsala,byte piso, ushort capacidad)
    {
        this.idsala=idsala;
        this.piso=piso;
        this.capacidad=capacidad;
    }

    public Sala()
    {
    }
}
