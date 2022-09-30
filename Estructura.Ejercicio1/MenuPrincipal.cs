//no tiene namespace  => "global"

internal static class MenuPrincipal
{
    public static int Mostrar() //devuelve 0-5 la opcion seleccionada
    {
        Console.WriteLine("1-Alta de persona");
        Console.WriteLine("2-Baja de persona");
        Console.WriteLine("3-Mostrar lista de personas");
        Console.WriteLine("4-Grabar lista de personas");
        Console.WriteLine("5-Cargar lista de personas");
        Console.WriteLine("0-Salir del sistema");        

        return Usuario.PedirEntero("Ingrese una opción entre 0 y 5 y presione [enter]", min:0, max:5); //le pide al usuario un numero entero de 0-5
    }
}
