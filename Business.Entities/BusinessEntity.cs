using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{


    public class BusinessEntity
    {

        #region Enumeradores
        

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }

        #endregion

        #region Constructores
        public BusinessEntity() {
            this.State = States.New;
        }
        #endregion

        #region Propiedades
        private States _State;
        public States State
        {
            get { return _State; }
            set { _State = value; }
        }

        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        #endregion
    }

}
