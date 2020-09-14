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
    public class PersonasLogic : BusinessLogic
    {

        private PersonasAdapter _PersonaData;
        public PersonasAdapter PersonaData
        {
            get { return _PersonaData; }
            set { _PersonaData = value; }
        }

        public PersonasLogic()
        {
            PersonaData = new PersonasAdapter();
        }

        public Persona GetOne(int ID)
        {
            return PersonaData.GetOne(ID);
        }

        public List<Persona> GetAll()
        {
            return PersonaData.GetAll();
        }

        public List<Plan> GetPlanes()
        {
            return PersonaData.GetPlanes();
        }

        public void Save(Persona personaGuard)
        {
            PersonaData.Save(personaGuard);
        }

        public void Delete(int ID)
        {
            PersonaData.Delete(ID);
        }
    }
}
