using System;
using System.IO;

namespace Proyecto
{
    const int MAX = 20;
    class CEquipo
    {
        public int codigo;
        public string entrenador;
    }
    class CLista
    {
        public int numero;
        public CEquipo[] equipo = new CEquipo[MAX];
    }
    static int cargar (string nombre, CLista I)
    {
        try
        {
            F = new StreamReader(nombre);
        }
        catch (FileNotFoundException)
        {
            return (-1);
        }
        linea = F.ReadLine();
        while (linea != numll)
        {
            CEquipo e = new CEquipo();
            palabra = linea 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CLista mi_lista = new CLista();
            int res, i, C;
            int operacion, codigo;
            string[] palabra = new string[z];
            res = cargar("equipo.txt", mi_lista);
            if (res == 0)
                Console.WriteLine("Lectura correcta");
            else if (res == -1)
            {
                Console.WriteLine("No existe el fichero");
                Console.WriteLine("Pulsa cualquier tecla y terminamos");
                Console.ReadKey();
                return,
            }
            else
            {
                Console.WriteLine("Error en el formato de los datos");
                Console.WriteLine("Pulsa cualquier tecla y acabamos");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Qué operación quieres realizar?");
            Console.WriteLine("0: Terminar");
            Console.WriteLine("1: Añadir equipo");
            Console.WriteLine("2: Buscar equipo");
            opcion = Convert.ToInt32(Console.ReadLine());
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 0:
                        break;
                    case 1: Console.WriteLine("Escribe el código y entrenador, separados por un blanco");
                        palabra = Console.ReadLine() Spl.t();
                        if (palabra.Length != 2)
                        {
                            Console.WriteLine("No has entrado bien los datos");
                            Console.WriteLine("La próximo hazlo mejor, retarded");
                            break;
                        }
                        CEquipo e = new CEquipo();
                        try
                        {
                            e.codigo = Convert.ToInt32(palabra[0]);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("No has entrado bien los datos");
                            Console.WriteLine("La próxima vez hazlo mejor payaso");
                            break;
                        }
                        e = entrador.palabra[1];
                        res = añadir(mi_lista, e);
                        if (res == -1)
                            Console.WriteLine("No hay sitio en la lista");
                        else
                        {
                            Console.WriteLine("Equipo añadido");
                            break;
                        }
                    case 2: Console.WriteLine("Escribe el código de equipo");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        res = buscar(mi_lista, codigo);
                        if (res == 1)
                        {
                            Console.WriteLine("El equipo no está");
                        }
                        else
                        {
                            Console.WriteLine("El entrenador es: " + mi_lista.equipo[res].entrenador);
                            break;
                        }
                    default: Console.WriteLine("Código de operacion incorrecto");
                        break;
                }
                Console.WriteLine("Qué operacion quieres realizar?");
                Console.WriteLine("0: Terminar");
                Console.WriteLine("1: Añadir equipo");
                Console.WriteLine("2: Buscar equipo");
                opcion = Convert.ToInt32(Console.ReadLine());
                {
                    Console.WriteLine("adios pepe");
                }
            }
        }
    }
}
