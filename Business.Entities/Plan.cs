using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan:BusinessEntity
    {
        #region Propiedades
        public string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int _IDEspecialidad;
        public int IDEspecialidad
        {
            get { return _IDEspecialidad; }
            set { _IDEspecialidad = value; }
        }

        public string _DescEspecialidad;

        public string DescEspecialidad
        {
            get { return _DescEspecialidad; }
            set { _DescEspecialidad = value; }
        }
        #endregion
    }
}
