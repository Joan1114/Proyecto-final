using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Proyecto Final*********");

            string[] ced1 = new string[5];
            string[] nombre = new string[5];
            int[] clave = new int[5];
            int rol = 0;
            int estado = 0;
            long ced_int;
            string name = "";

            int cont = 0;
            while (cont <= 4)
            {
                for (int i = 0; i <= cont; i++)
                {
                    Console.Write("\nIngrese el No. usuario: ");
                    ced1[cont] = Console.ReadLine();
                    if (long.TryParse(ced1[cont], out ced_int) == false)
                    {
                        do
                        {
                            Console.WriteLine("Digite el No. usuario otra vez, no puede contener letras o signos");
                            ced1[cont] = Console.ReadLine();
                        } while (long.TryParse(ced1[cont], out ced_int) == false);
                    }

                    if (ced1[cont].Length != 11)
                    {
                        do
                        {
                            Console.WriteLine("Debe tener 11 digitos, ingrese de nuevo");
                            Console.Write("Ingrese el No. usuario: ");
                            ced1[cont] = Console.ReadLine();

                        } while (ced1[cont].Length < 11 || ced1[cont].Length > 11);
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write("Ingrese su nombre: ");
                nombre[cont] = "";
                nombre[cont] = Console.ReadLine();

                Console.Write("Inserte la clave con la que quiere ingresar: ");
                clave[cont] = 0;
                clave[cont] = Convert.ToInt32(Console.ReadLine());

                DateTime[] fecha_creacion = new DateTime[5];
                fecha_creacion[cont] = DateTime.Now;
                Console.WriteLine("El usuario se creo en: " + fecha_creacion[cont].ToString());

                Console.WriteLine("\nUsuario registrado");

                cont++;
            }

            Console.WriteLine("\nLogin Session");

            string ced = "";
            int clave1;
            int c = 0;
            int p = 0;
            int valido = 0;

            do
            {
                Console.Write("\nUsuario: ");
                ced = Console.ReadLine();

                Console.Write("Contraseña: ");
                clave1 = Convert.ToInt32(Console.ReadLine());

                if (ced1[0] == ced && clave[0] == clave1)
                {
                    c = 0;
                    p = 0;
                    name = nombre[0];
                    valido = 1;
                }
                else if (ced1[1] == ced && clave[1] == clave1)
                {
                    c = 1;
                    p = 1;
                    name = nombre[1];
                    valido = 1;
                }
                else if (ced1[2] == ced && clave[2] == clave1)
                {
                    c = 2;
                    p = 2;
                    name = nombre[2];
                    valido = 1;
                }
                else if (ced1[3] == ced && clave[3] == clave1)
                {
                    c = 3;
                    p = 3;
                    name = nombre[3];
                    valido = 1;
                }
                else if (ced1[4] == ced && clave[4] == clave1)
                {
                    c = 4;
                    p = 4;
                    name = nombre[4];
                    valido = 1;
                }
                else
                {
                    valido = 0;
                    Console.WriteLine("El usuario que intento registrar no es correcto, intente otra vez");
                }

                if (valido == 1)
                {
                    Random aleatorio = new Random();
                    int rnd = aleatorio.Next(1, 3);
                    string role_name = (rol == 1 ? "Administrador" : rol == 2 ? "Supervisor" : "Vendedor");

                    Random aleatory = new Random();
                    estado = aleatory.Next(1, 2);
                    string estados = (estado == 1 ? "Activo" : "Inactivo");

                    if (estados == "Activo")
                    {
                        Console.Clear();
                        Console.WriteLine("\nBienvenido {0}, ha ingresado con el usuario {1}, su rol es {2}", name, ced1[c], role_name);
                    }
                    else if (estados == "Inactivo")
                    {
                        valido = 0;
                        Console.Clear();
                        Console.WriteLine("El usuario que registro se encuentra inactivo, intente con otro");
                    }
                }
            } while (valido == 0);
            Console.ReadKey();
            
        }
    }
}
