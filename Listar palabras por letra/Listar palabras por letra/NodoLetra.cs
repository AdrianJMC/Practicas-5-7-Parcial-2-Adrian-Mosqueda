public class NodoLetra
{
    public char Letra { get; set; }
    public ListaPalabras ListaPalabras { get; set; }
    public NodoLetra Siguiente { get; set; }

    public NodoLetra(char letra)
    {
        Letra = letra;
        ListaPalabras = new ListaPalabras();
        Siguiente = null;
    }
}
