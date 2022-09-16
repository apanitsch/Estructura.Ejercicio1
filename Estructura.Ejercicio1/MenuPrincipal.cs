//no tiene namespace  => "global"

internal static class MenuPrincipal
{
    public static int Mostrar() //devuelve 0-5 la opcion seleccionada
    {
        Console.WriteLine("1-Alta");
        Console.WriteLine("2-Baja");
        Console.WriteLine("3-MostrarLista");
        Console.WriteLine("4-Grabar");
        Console.WriteLine("5-Cargar");
        Console.WriteLine("0-Salir del sistema");
        Console.WriteLine("Ingrese una opción y presione [enter]");

        return Usuario.PedirEntero(min:0, max:5); //le pide al usuario un numero entero de 0-5
    }
}
