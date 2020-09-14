using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EspecialidadLogic:BusinessLogic
    {
        #region Propiedades

        public EspecialidadAdapter _EspecialidadData;
        public EspecialidadAdapter EspecialidadData
        {
            get { return _EspecialidadData; }
            set { _EspecialidadData = value; }

        }

        #endregion

        #region Constructores
        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
        }



        #endregion


        #region Metodos

        public Especialidad GetOne(int ID)
        {
            return EspecialidadData.GetOne(ID);

        }

        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }

        public void Save(Especialidad EspecialidadGuard)
        {

            EspecialidadData.Save(EspecialidadGuard);

        }

        public void Delete(int ID)
        {
            EspecialidadData.Delete(ID);

        }

       
        #endregion
    }
}
