public class ListaPalabras
{
    private NodoPalabra primero;

    public ListaPalabras()
    {
        primero = null;
    }

    // Método para agregar una palabra a la lista
    public void AgregarPalabra(string palabra)
    {
        NodoPalabra nuevo = new NodoPalabra(palabra);
        if (primero == null)
        {
            primero = nuevo;
        }
        else
        {
            NodoPalabra actual = primero;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;  // Agregar al final de la lista
        }
    }

    // Método para mostrar las palabras en la lista
    public string MostrarPalabras()
    {
        NodoPalabra actual = primero;
        string resultado = "";
        while (actual != null)
        {
            resultado += actual.Palabra + " ";
            actual = actual.Siguiente;
        }
        return resultado.Trim();
    }
}
