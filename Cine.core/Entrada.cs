namespace Cine.Core;

public class Entrada
{
    public int identrada { get; set; }
    public int idproyeccion { get; set; }
    public ushort idcliente { get; set; }
    public decimal precio { get; set; }
    public Entrada(int identrada,int idproyeccion,ushort idcliente, decimal precio)
    {
        this.identrada=identrada;
        this.idproyeccion=idproyeccion;
        this.idcliente=idcliente;
        this.precio=precio;
    }
}