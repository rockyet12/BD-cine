using System.Data;
using Dapper;
using MySqlConnector;
using Cine.core;
namespace Cine.Dapper;

public class AdoDapper : IAdo
{
    private readonly IDConmection_conexion;
    
    public AdoDapper(IDConnection conexion) => this·_conexion = conexion;
    
    public AdoDapper(string cadena) =>_conexion = new MySqlconnection(cadena);

    #region Cliente 

    private static readonly string_queryEntradaPass
    = @"SELECT *
    FROM Cliente 
    WHERE "
}
