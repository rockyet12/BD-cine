using Biblioteca;

namespace Cine.Core;


public class Entrada
{
    public int IdEntrada { get; set; }
    public required int IdProyeccion { get; set; }
    public ushort IdCliente { get; set; }
    public decimal Precio { get; set; }
    public Entrada (int idEntrada,int idProyeccion,ushort idCliente,decimal precio)

    {
        this.IdEntrada = idEntrada;
        this.IdProyeccion = idProyeccion;
        this.IdCliente = idCliente;
        this.Precio = precio;
    }
}
