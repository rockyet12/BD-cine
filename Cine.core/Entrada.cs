namespace Cine.Core;


public class Entrada
{
    public int IdEntrada { get; set; }
    public Proyeccion IdProyeccion { get; set; }
    public ushort IdCliente { get; set; }
    public decimal Precio { get; set; }
    public Entrada (int idEntrada,Proyeccion idProyeccion,ushort idCliente,decimal precio)

    {
        IdEntrada = idEntrada;
        IdProyeccion = idProyeccion;
        IdCliente = idCliente;
        Precio = precio;
    }
}
