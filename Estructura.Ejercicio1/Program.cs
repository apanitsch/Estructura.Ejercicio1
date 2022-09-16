//El espacio de nombres de este archivo es "global" = no tener ninguna declaración "namespace"

while (true) 
{
    //menu principal
    int opcion = MenuPrincipal.Mostrar(); //devuelve 0-5
    if (opcion == 1)
    {
        //ingresar una nueva persona.
        RegistroPersonas.Alta();
    }
    else if (opcion == 2)
    {
        //dar de baja
        RegistroPersonas.Baja();
    }
    else if (opcion == 3)
    {
        //mostrar lista de personas
        RegistroPersonas.MostrarLista();
    }
    else if (opcion == 4)
    {
        //Grabar en un archivo
        RegistroPersonas.Grabar();
    }
    else if (opcion == 5)
    {
        //Cargar del archivo
        RegistroPersonas.Cargar();
    }
    else if (opcion == 0)
    {
        //Salir del sistema
        return;
    }
    else
    {
        //esto no debería pasar nunca => si pasa tiro un error.
        throw new ApplicationException("Opción inválida");
    }
}