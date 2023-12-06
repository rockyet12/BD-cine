using Cine.Core;
namespace Cine.Test;

public class TestAdoSala : TestAdo
{
    [Theory]
    [InlineData(1, 2, 30)]
    [InlineData(2, 4, 20)]
    public void TraerSalaPorId(byte Id, byte piso, ushort capacidad)
    {
        var sala = Ado.ObtenerSalas(Id);

        Assert.NotNull(sala);
        Assert.Equal(piso, sala.piso);
        Assert.Equal(capacidad, sala.capacidad);
    }

    [Fact]
    public void TraerSalas()
    {
        var sala = Ado.ObtenerSalas();

        Assert.NotEmpty(sala);
    }

    [Fact]
    public void AltaSala()
    {
        byte Idsala = 5;
        byte Piso = 2;
        byte Capacidad = 30;

        var nuevasala = new Sala()
        {
            idsala = Idsala, 
            piso = Piso, 
            capacidad = Capacidad
        };

        Ado.AltaSala(nuevasala);
    }
    
}
