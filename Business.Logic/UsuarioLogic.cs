using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {

        #region Propiedades

        public UsuarioAdapter _UsuarioData; 
        public UsuarioAdapter UsuarioData
        {
            get{ return _UsuarioData; }
            set { _UsuarioData = value; }

        }

        #endregion

        #region Constructores
        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }



        #endregion


        #region Metodos

        public Usuario GetOne(int ID)
        {
            return UsuarioData.GetOne(ID);

        }
        public Usuario GetOne(string usuario)
        {
            return UsuarioData.GetOne(usuario);

        }
        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public void Save(Usuario UsuarioGuard)
        {

            UsuarioData.Save(UsuarioGuard);

        }

        public void Delete(int ID)
        {
            UsuarioData.Delete(ID);

        }

        public Usuario validarUsuario(string txtUsuario, string txtContraseña)
        {

            Usuario usuarioActual = new Usuario();
            usuarioActual = this.GetOne(txtUsuario);


            if (usuarioActual is null || (usuarioActual.Clave != txtContraseña))
            {
                return null;
            }
            else
            {
                return usuarioActual;
            }

        }


        #endregion
    }
}
