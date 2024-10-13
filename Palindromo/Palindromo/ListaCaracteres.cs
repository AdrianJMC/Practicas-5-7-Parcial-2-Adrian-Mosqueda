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

    // Método para verificar si la palabra es un palíndromo
    public bool EsPalindromo()
    {
        // Convertir la lista enlazada en una lista enlazada invertida para comparar
        NodoCaracter invertido = InvertirLista();

        // Comparar la lista original con la lista invertida
        NodoCaracter original = primero;
        NodoCaracter actualInvertido = invertido;

        while (original != null && actualInvertido != null)
        {
            if (original.Caracter != actualInvertido.Caracter)
            {
                return false;
            }
            original = original.Siguiente;
            actualInvertido = actualInvertido.Siguiente;
        }

        return true;
    }

    // Método para invertir la lista enlazada (sin modificar la original)
    private NodoCaracter InvertirLista()
    {
        NodoCaracter anterior = null;
        NodoCaracter actual = primero;

        while (actual != null)
        {
            NodoCaracter nuevoNodo = new NodoCaracter(actual.Caracter);
            nuevoNodo.Siguiente = anterior;
            anterior = nuevoNodo;
            actual = actual.Siguiente;
        }

        return anterior;  // Retornar el nuevo nodo que ahora es el primero de la lista invertida
    }
}
