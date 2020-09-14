using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class DocenteCurso:BusinessEntity
    {
        #region Enumeradores
        public enum TiposCargos
        {
            Docente,
            NoDocente,
            Alumno
        }
        #endregion


        #region Propiedades
        public TiposCargos _Cargo;
        public TiposCargos Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        public int _IDCursos;
        public int IDCursos
        {
            get { return _IDCursos; }
            set { _IDCursos = value; }
        }

        public int _IDDocente;
        public int IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }

        #endregion
    }
}
