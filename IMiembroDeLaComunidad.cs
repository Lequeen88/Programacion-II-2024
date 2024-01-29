using Clase1;

public interface IMiembroDeLaComunidad
{
    MiembroDeLaComunidad GetMiembro();
    public string Nombre { get; set; }
    void Saludar();
    void Reirse();
    void Trotar();
    void Comer();
}