using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;

namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioLogic ul = new UsuarioLogic();
            Usuarios usuarios = new Usuarios();
            usuarios.Menu();
        }
    }
}
