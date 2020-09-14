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
    public class PlanLogic : BusinessLogic
    {
        private PlanAdapter _PlanData;
        public PlanAdapter PlanData
        {
            get { return _PlanData; }
            set { _PlanData = value; }
        }

        public PlanLogic()
        {
            PlanData = new PlanAdapter();
        }

        private PlanAdapter _EspecialidadData;
        public PlanAdapter EspecialidadData
        {
            get { return _EspecialidadData; }
            set { _EspecialidadData = value; }
        }

        public Plan GetOne(int ID)
        {
            return PlanData.GetOne(ID);
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }

        public List<Especialidad> GetEspecialidad()
        {
            return PlanData.GetEspecialidad();
        }
        public void Save(Plan planGuard)
        {
            PlanData.Save(planGuard);
        }

        public void Delete(int ID)
        {
            PlanData.Delete(ID);
        }

        
    }
}
