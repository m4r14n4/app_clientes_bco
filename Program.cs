using System;
using System.Collections.Generic;
using Ejemplo;

namespace Ejemplo
{
    class Program
    {


        static void MostrarMenu()
        {
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("1- Agregar Cliente");
            Console.WriteLine("2- Modificar Cliente");
            Console.WriteLine("3- Eliminar Cliente");
            Console.WriteLine("0- Salir");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema \n\nElija una opcion:");
            
            MostrarMenu();

            int opcion = int.Parse(Console.ReadLine());
            while(opcion != 0)
            {                
                switch(opcion)
                {
                    case 1:
                        //sumar TODO
                        break;
                    case 2:         
                        //multiplicar TODO           
                        break;
                    case 3:         
                        //multiplicar TODO           
                        break;
                    default:
                        Console.WriteLine("Opción inválida");                    
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());
                        break;            
                }
            }

            Console.WriteLine("Chau!!!!");
            Console.ReadKey();
        

       
           
            List<Persona> listaPersonas = new List<Persona>();

            Cliente cliente = new Cliente();
            cliente.DNI = 152232323;
            cliente.SetNombre("er");
            cliente.Apellido = "Sanchez";
            cliente.Sueldo = 45000;

            listaPersonas.Add(cliente);

            Persona nuevaPersona = new Persona();
            nuevaPersona.DNI = 35939434;
            nuevaPersona.SetNombre("Morty");
            nuevaPersona.Apellido = "Smith";

            listaPersonas.Add(nuevaPersona);

            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(cliente);
            //listaClientes.Add(nuevaPersona);//ESTO NO SE PUEDE

            Console.WriteLine(cliente.GetNombre());
            Console.WriteLine(cliente.Apellido);

        }    // OTRO EJEMPLO //

            /* si queremos setear las propiedades al construirlo
            Rectangulo rect1 = new Rectangulo { Alto = 2, Ancho = 4};
            Triangulo tri1 = new Triangulo { Lado1=3, Lado2=2, Lado3= 5};
            List<Figura> listaFiguras = new List<Figura>();
            listaFiguras.Add(rect1);
            listaFiguras.Add(tri1);

            foreach(Figura figura in listaFiguras)
            {
                Console.WriteLine("Tiene un perímetro de:" 
                    + figura.CalcularPerimetro());
            }



            Console.ReadKey();*/
        
    }
}
