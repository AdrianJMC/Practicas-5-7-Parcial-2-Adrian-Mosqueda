public class ListaCaracteres
{
    private NodoCaracter primero;

    public ListaCaracteres()
    {
        primero = null;
    }

    // Método para agregar un carácter al final de la lista
    public void AgregarCaracter(char caracter)
    {
        NodoCaracter nuevo = new NodoCaracter(caracter);
        if (primero == null)
        {
            primero = nuevo;
        }
        else
        {
            NodoCaracter actual = primero;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Método para invertir la lista enlazada
    public void Invertir()
    {
        NodoCaracter anterior = null;
        NodoCaracter actual = primero;
        NodoCaracter siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;  // Guardar el siguiente nodo
            actual.Siguiente = anterior;   // Invertir la dirección del enlace
            anterior = actual;             // Mover 'anterior' un paso adelante
            actual = siguiente;            // Mover 'actual' un paso adelante
        }

        primero = anterior;  // 'anterior' ahora es el nuevo primer nodo
    }

    // Método para obtener la palabra como string a partir de la lista enlazada
    public string ObtenerPalabra()
    {
        string resultado = "";
        NodoCaracter actual = primero;
        while (actual != null)
        {
            resultado += actual.Caracter;
            actual = actual.Siguiente;
        }
        return resultado;
    }
}
