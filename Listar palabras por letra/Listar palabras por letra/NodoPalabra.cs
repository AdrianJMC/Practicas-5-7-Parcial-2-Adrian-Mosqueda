public class NodoPalabra
{
    public string Palabra { get; set; }
    public NodoPalabra Siguiente { get; set; }

    public NodoPalabra(string palabra)
    {
        Palabra = palabra;
        Siguiente = null;
    }
}
