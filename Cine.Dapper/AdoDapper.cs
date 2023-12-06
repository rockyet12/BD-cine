using System.Data;
using Dapper;
using MySqlConnector;
using Cine.Core;

namespace Cine.Dapper
{
    public class AdoDapper : IAdo
    {
        private readonly IDbConnection _conexion;

        public AdoDapper(IDbConnection conexion) => _conexion = conexion;

        public AdoDapper(string cadena) => _conexion = new MySqlConnection(cadena);

        #region Sala

        private static readonly string _queryObtenerSalas
            = @"SELECT *
               FROM Sala
               WHERE idsala = @unId";

        private static readonly string _querySalas
            = @"SELECT *
               FROM Sala";

        private static readonly string _queryAltasala
            = @"INSERT INTO Sala (idsala, piso, capacidad) 
                            VALUES(@idsala, @piso, @capacidad)";

        public void AltaSala(Sala sala)
            => _conexion.Execute(
                _queryAltasala,
                new
                {
                    idsala = sala.idsala,
                    piso = sala.piso,
                    capacidad = sala.capacidad
                }
            );

        public Sala? ObtenerSalas(byte Id)
            => _conexion.QueryFirstOrDefault<Sala>(_queryObtenerSalas, new { unId = Id });

        List<Sala> IAdo.ObtenerSalas()
        => _conexion.Query<Sala>(_querySalas).ToList();


        #endregion Sala
    }
}
