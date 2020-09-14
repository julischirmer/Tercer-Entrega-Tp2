using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        #region Propiedades
        public int _IdUsuaro;
        public int IdUsuario
        {
            get { return _IdUsuaro; }
            set { _IdUsuaro = value; }
        }
        public int _IdModulo;
        public int IdModulo
        {
            get { return _IdModulo; }
            set { _IdModulo = value; }
        }
        public bool _PermiteAlta;
        public bool PermiteAlta
        {
            get { return _PermiteAlta; }
            set { _PermiteAlta = value; }
        }
        public bool _PermiteBaja;
        public bool PermiteBaja
        {
            get { return _PermiteBaja; }
            set { _PermiteBaja = value; }
        }
        public bool _PermiteModificacion;
        public bool PermiteModificacion
        {
            get { return PermiteModificacion; }
            set { PermiteModificacion = value; }
        }
        public bool _PermiteConsulta;
        public bool PermiteConsulta
        {
            get { return _PermiteConsulta; }
            set { _PermiteConsulta = value; }
        }

        #endregion
    }
}
