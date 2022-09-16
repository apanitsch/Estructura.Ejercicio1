using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal static class RegistroPersonas
{
    static List<Persona> personas = new();

    public static void Alta()
    {
        //pedirle los datos necesarios para crear un objeto persona al usuario
        //y grabar ese objeto en una lista.
        var persona = new Persona();

        persona.Documento = Usuario.PedirEntero(min: 1_000_000, max: 99_999_999);
        persona.Nombre = Usuario.PedirCadena(max: 30);
        persona.Apellido = Usuario.PedirCadena(max: 30);
        persona.FechaNacimiento = Usuario.PedirFecha(max: DateTime.Now); //el enunciado dice "menor a la actual"

        //mas validaciones acá.
        //ejercicio: que no exista....        


        //guardar en memoria.
        personas.Add(persona);
    }

    public static void Baja()
    {
        Console.WriteLine("Ingrese nro. de doc. a dar de baja.");
        int documentoBaja = Usuario.PedirEntero(min: 1_000_000, max: 99_999_999);

        //forma corta (ejercicio:entender la linea)
        //personas.Remove(personas.Single(p => p.Documento == documentoBaja));

        foreach (var persona in personas)
        {
            if (persona.Documento == documentoBaja)
            {
                personas.Remove(persona);
                return;
            }
        }

        Console.WriteLine($"No se encontró una persona con DNI {documentoBaja}");
    }

    internal static void Grabar()
    {
        //Grabar: un archivo de texto en donde cada línea representa una persona.
        //Esa línea va a tener los datos de la persona separados por "|" ("pipe")

        //se le pasa el nombre del archivo.
        //La palabra clave "using" le dice a .Net que cierre el archivo
        //tan pronto como termine este método.
        //(Que NO espere al "recolector de basura" para hacerlo).
        using var archivoPersonas = new StreamWriter("Personas.txt");     
        
        //archivoPersonas tiene métodos MUY parecidos a los de la consola.
        //Write, WriteLine, etc...
        foreach(var persona in personas)
        {
            var linea = $"{persona.Documento}|{persona.Nombre}|{persona.Apellido}|{persona.FechaNacimiento}";
            archivoPersonas.WriteLine(linea);
        }
    }

    internal static void Cargar()
    {
        //borrar las personas que ya existen... ?
        personas.Clear();

        using var archivoPersonas = new StreamReader("Personas.txt");
        while (!archivoPersonas.EndOfStream)
        {
            string proximaLinea = archivoPersonas.ReadLine();
            string[] datosSeparados = proximaLinea.Split('|');

            var persona = new Persona();
            persona.Documento = int.Parse(datosSeparados[0]);
            persona.Nombre = datosSeparados[1];
            persona.Apellido = datosSeparados[2];
            persona.FechaNacimiento = DateTime.Parse(datosSeparados[3]);

            personas.Add(persona);
        }
    }

    internal static void MostrarLista()
    {
        foreach(var persona in personas)
        {
            Console.WriteLine($"Documento:{persona.Documento}");
            Console.WriteLine($"Apellido:{persona.Apellido}");
            Console.WriteLine($"Nombre:{persona.Nombre}");
            Console.WriteLine($"FechaNacimiento:{persona.FechaNacimiento}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
