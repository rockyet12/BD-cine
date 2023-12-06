namespace Cine.Core;
public interface IAdo
{
    void AltaSala (Sala sala);
    List<Sala>ObtenerSalas();
    Sala? ObtenerSalas(byte Id);
}
