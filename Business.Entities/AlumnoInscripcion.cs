using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{

    class AlumnoInscripcion:BusinessEntity
    {

        #region Enumeradores
        #endregion

        #region Propiedades

        public string _Condicion;
        public string Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }

        public int _Alumno;
        public int Alumno
        {
            get { return _Alumno; }
            set { _Alumno = value; }
        }

        public int _IDCurso;
        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        public int _Nota;
        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }
        #endregion

        #region Constructores
        #endregion

        #region Metodos
        #endregion
    }
}
