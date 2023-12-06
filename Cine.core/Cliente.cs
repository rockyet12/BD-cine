namespace Cine.Core;

public class Cliente
{
    public ushort idcliente { get; set; }
    public string  nombre { get; set; }
    public string apellido { get; set; }
    public string  email { get; set; }
    public string  contra { get; set; }

    public Cliente(ushort idcliente, string nombre , string apellido, string email, string contra)
    {
        this.idcliente=idcliente;
        this.nombre=nombre;
        this.apellido=apellido;
        this.email=email;
        this.contra=contra;
    }
}
