using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Persona:BusinessEntity
    {

        #region Enumeradores
        public enum TiposPersonas
        {
            Docente, 
            Administrador,
            Alumno

        }

        #endregion

        #region Propiedades
        string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public DateTime _FechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        public int _IDPlan;

        public int IDPlan
        {
            get { return _IDPlan; }
            set { _IDPlan = value; }
        }

        public string _DescPlan;
        public string DescPlan
        {
            get { return _DescPlan; }
            set { _DescPlan = value; }
        }

        public int _Legajo;

        public int Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }

        string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
       
        TiposPersonas _TipoPersona;
        
        public TiposPersonas TipoPersona
        {
            get { return _TipoPersona; }
            set { _TipoPersona = value; }
        }
        #endregion
    }
}
