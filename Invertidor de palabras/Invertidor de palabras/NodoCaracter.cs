public class NodoCaracter
{
    public char Caracter { get; set; }
    public NodoCaracter Siguiente { get; set; }

    public NodoCaracter(char caracter)
    {
        Caracter = caracter;
        Siguiente = null;
    }
}
