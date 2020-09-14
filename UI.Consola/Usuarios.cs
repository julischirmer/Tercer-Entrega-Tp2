using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace UI.Consola
{
    public class Usuarios
    {
        #region Propiedades
        private UsuarioLogic _UsuarioNegocio;
        public UsuarioLogic UsuarioNegocio {

            get { return _UsuarioNegocio; }
            set { _UsuarioNegocio = value; }
        }

        #endregion

        #region Constructores   
       
        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();

        }

        #endregion

        #region Metodos

        public void ListadoGeneral()
        {
 
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                
                try
                {
                    MostrarDatos(usr);
                    Console.ReadLine();

                }
                catch (Exception)
                {

                    Console.WriteLine("Se ha generado un error");
                }

            }

        }
        
       
		        
		  public void Consultar()
        {
            try
            {
                Console.Clear();
            Console.Write("Ingrese el ID del usuario a consultar: ");
            int ID = int.Parse(Console.ReadLine());
            this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException )
            {
                Console.WriteLine("La ID ingresada debe ser un número entero.");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Agregar()
        {
            Usuario usuario = new Usuario();
            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese Clave: ");
            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese Email: ");
            usuario.Email = Console.ReadLine();
            Console.Write("Ingrese Habilitacion de Usuario (1-Si/otro-No): ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0} ", usuario.ID);

        }


        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.Write("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.Write("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese Email: ");
                usuario.Email = Console.ReadLine();
                Console.Write("Ingrese Habilitacion de Usuario (1-Si/otro-No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);

            }
            catch(FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");

            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }

        }
         

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
                Console.WriteLine("Usuario" ,ID, "eliminado con exito");
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");

            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
    

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0} ",usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}",usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            
            Console.WriteLine();
        }


        public void Menu()
        {

            Console.WriteLine("1– Listado General \n2– Consulta \n3– Agregar \n4- Modificar \n5- Eliminar \n6- Salir");
            ConsoleKeyInfo opc = Console.ReadKey();
            switch (opc.Key)
            {
                case ConsoleKey.D1:
                    {
                        ListadoGeneral();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Consultar();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        Agregar();
                        break;
                    }
                case ConsoleKey.D4:
                    {
                       Modificar();
                        break;
                    }
                case ConsoleKey.D5:
                    {
                        Eliminar();
                        break;
                    }
                case ConsoleKey.D6:
                    {
                        break;
                    }
            }




        }

            
        #endregion

    }
}
