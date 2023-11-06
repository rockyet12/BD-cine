namespace Biblioteca;

public class Cliente
{
    public ushort IdCliente { get; set; }
    public string nombre { get; set;}
    public string Apellido { get; set;}
    public string Email { get; set; }
    public string Contra { get; set; }
    public List<Entrada>Entradas = new();
    public Cliente(ushort idCliente, string nombre, string apellido, string email, string contra)
    {
        this.IdCliente = idCliente;
        this.nombre = nombre; 
        this.Apellido = apellido;
        this.Email = email;
        this.Contra = contra;
        this.Entradas = new List<Entrada>();
    }
}