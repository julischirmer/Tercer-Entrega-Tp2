using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace Business.Logic
{
    public class MateriaLogic: BusinessLogic
    {
        private MateriaAdapter _MateriaData;
        public MateriaAdapter MateriaData
        {
            get { return _MateriaData; }
            set { _MateriaData = value; }
        }

        public MateriaLogic()
        {
            MateriaData = new MateriaAdapter();
        }

        public Materia GetOne(int ID)
        {
            return MateriaData.GetOne(ID);
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }

        public List<Plan> GetPlanes()
        {
            return MateriaData.GetPlanes();
        }

        public void Save(Materia materiaGuard)
        {
            MateriaData.Save(materiaGuard);
        }

        public void Delete(int ID) {
            MateriaData.Delete(ID);
        }
    }
}
