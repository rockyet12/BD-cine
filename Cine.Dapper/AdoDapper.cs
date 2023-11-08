using System.Data;
using Dapper;
using MySqlConnector;
using Cine.core;
using Biblioteca;
using Cine.Core;

namespace Cine.Dapper;

public class AdoDapper : IAdo
{
    private readonly IDbConnection _conexion;
    
    public AdoDapper(IDbConnection conexion) => _conexion = conexion;
    
    public AdoDapper(string cadena) =>_conexion = new MySqlConnection(cadena);

    #region Cliente 

    private static readonly string _queryClientecontra
    = @"SELECT*
    FROM Cliente 
    WHERE email
    AND contra = SHA2(@unacontra, 256)
    LIMIT 1";

    public void AltaCliente(Cliente cliente)
    {
        var parametros = new DynamicParameters();
        
        parametros.Add("@unIdCliente",direction: ParameterDirection.Output);
        parametros.Add("@unnombre", cliente.nombre);
        parametros.Add("@unapellido", cliente.Apellido);
        parametros.Add("@unaemail", cliente.Email);
        parametros.Add("@unacontra", cliente.Contra);

        _conexion.Execute("AltaCliente",parametros);

        cliente.IdCliente = (ushort)parametros.Get<short>("@unIdCliente");
    }
    public void AltaEntrada(Entrada entrada)
    {
        var parametros = new DynamicParameters();

        parametros.Add("@")
    }
}