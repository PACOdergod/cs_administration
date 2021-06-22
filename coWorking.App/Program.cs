using System;
using coWorking.Data;

namespace coWorking.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // var userData = new UserData();
            // userData.CreatedAdmin();

            string roleSelected = "";
            while ( roleSelected!="1" && roleSelected!="2" )
            {
                Console.WriteLine("1 = Admin");
                Console.WriteLine("2 = Usuario");
                roleSelected = Console.ReadLine();
            }

            if (roleSelected == "1") // ADMIN
            {
                string menuAdmin = "";
                while ( menuAdmin!="1" && menuAdmin!="2" )
                {
                    Console.WriteLine("1 = Administrar puesto");
                    Console.WriteLine("2 = Administrar usuario");
                    menuAdmin = Console.ReadLine();
                }

                if (menuAdmin == "1")
                {
                    string menuPuesto = "";
                    while (menuPuesto!= "1" && menuPuesto!= "2" && 
                           menuPuesto!= "3" && menuPuesto!= "4")
                    {
                        Console.WriteLine("1= Crear, 2= Editar, 3= Eliminar, 4= Bloquear");
                        menuPuesto = Console.ReadLine();
                    }

                    switch (menuPuesto)
                    {
                        case "1":
                            System.Console.WriteLine("Opcion crear puesto");
                            break;
                        case "2":
                            System.Console.WriteLine("Opcion editar puesto");
                            break;
                        case "3":
                            System.Console.WriteLine("Opcion eliminar puesto");
                            break;
                        case "4":
                            System.Console.WriteLine("Opcion bloquear puesto");
                            break;
                    }

                }
                if (menuAdmin == "2")
                {
                    string menuUsuario = "";
                    while (menuUsuario!= "1" && menuUsuario!= "2" && 
                           menuUsuario!= "3" && menuUsuario!= "4")
                    {
                        Console.WriteLine("1= Crear, 2= Editar, 3= Eliminar, 4= Cambiar contraseña");
                        menuUsuario = Console.ReadLine();
                    }

                    switch (menuUsuario)
                    {
                        case "1":
                            System.Console.WriteLine("Opcion crear usuario");
                            break;
                        case "2":
                            System.Console.WriteLine("Opcion editar usuario");
                            break;
                        case "3":
                            System.Console.WriteLine("Opcion eliminar usuario");
                            break;
                        case "4":
                            System.Console.WriteLine("Opcion cambiar contraseña");
                            break;
                    }
            
                }
            }
            if (roleSelected == "2") // User
            {
                
            }
            

        }
    }
}
