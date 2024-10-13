public class ListaPorLetra
{
    private NodoLetra primero;

    public ListaPorLetra()
    {
        primero = null;
    }

    // Método para agregar una palabra, asignándola a su lista por letra inicial
    public void AgregarPalabra(string palabra)
    {
        char letraInicial = char.ToLower(palabra[0]);  // Convertir la primera letra a minúsculas
        NodoLetra nodoLetra = BuscarLetra(letraInicial);

        if (nodoLetra == null)  // Si no existe la lista para la letra, se crea
        {
            nodoLetra = new NodoLetra(letraInicial);
            if (primero == null)
            {
                primero = nodoLetra;
            }
            else
            {
                NodoLetra actual = primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nodoLetra;  // Agregar al final de la lista de letras
            }
        }

        nodoLetra.ListaPalabras.AgregarPalabra(palabra);  // Agregar la palabra a la lista de esa letra
    }

    // Método para buscar una letra en la lista de letras
    private NodoLetra BuscarLetra(char letra)
    {
        NodoLetra actual = primero;
        while (actual != null)
        {
            if (actual.Letra == letra)
            {
                return actual;
            }
            actual = actual.Siguiente;
        }
        return null;
    }

    // Método para mostrar todas las palabras clasificadas por letra
    public string MostrarPalabrasPorLetra()
    {
        NodoLetra actual = primero;
        string resultado = "";

        while (actual != null)
        {
            resultado += $"Letra {char.ToUpper(actual.Letra)}: {actual.ListaPalabras.MostrarPalabras()}\n";
            actual = actual.Siguiente;
        }

        return resultado.Trim();
    }
}
