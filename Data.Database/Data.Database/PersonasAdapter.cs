using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class PersonasAdapter:Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT personas.id_persona, personas.nombre, personas.apellido, personas.direccion, " +
                    "personas.email, personas.telefono, personas.fecha_nac, personas.legajo, " +
                    "personas.tipo_persona, planes.id_plan, planes.desc_plan FROM personas " +
                    "INNER JOIN planes ON planes.id_plan = personas.id_plan ", sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                while (drPersonas.Read())
                {
                    Persona pers = new Persona();
                    pers.ID = (int)drPersonas["id_persona"];
                    pers.Nombre = (string)drPersonas["nombre"];
                    pers.Apellido = (string)drPersonas["apellido"];
                    pers.Direccion = (string)drPersonas["direccion"];
                    pers.Email = (string)drPersonas["email"];
                    pers.Telefono = (string)drPersonas["telefono"];
                    pers.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    pers.Legajo = (int)drPersonas["legajo"];
                    pers.TipoPersona = (Persona.TiposPersonas)drPersonas["tipo_persona"];
                    pers.IDPlan = (int)drPersonas["id_plan"];
                    pers.DescPlan = (string)drPersonas["desc_plan"];

                    personas.Add(pers);
                }
                drPersonas.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de personas", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }

        public Persona GetOne(int ID)
        {
            Persona pers = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT personas.id_persona, personas.nombre, personas.apellido, personas.direccion," +
                    " personas.email, personas.telefono, personas.fecha_nac, personas.legajo, personas.tipo_persona, planes.id_plan," +
                    " planes.desc_plan FROM personas " +
                    "INNER JOIN planes ON planes.id_plan = personas.id_plan WHERE id_persona = @id ", sqlConn);
                cmdPersonas.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                if (drPersonas.Read())
                {
                    pers.ID = (int)drPersonas["id_persona"];
                    pers.Nombre = (string)drPersonas["nombre"];
                    pers.Apellido = (string)drPersonas["apellido"];
                    pers.Direccion = (string)drPersonas["direccion"];
                    pers.Email = (string)drPersonas["email"];
                    pers.Telefono = (string)drPersonas["telefono"];
                    pers.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    pers.Legajo = (int)drPersonas["legajo"];
                    pers.TipoPersona = (Persona.TiposPersonas)drPersonas["tipo_persona"];
                    pers.IDPlan = (int)drPersonas["id_plan"];
                    pers.DescPlan = (string)drPersonas["desc_plan"];

                }
                drPersonas.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la persona", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return pers;
        }

        public List<Plan> GetPlanes()
        {
            List<Plan> planes = new List<Plan>();
            this.OpenConnection();
            SqlCommand cmdPlanes = new SqlCommand("SELECT id_plan, desc_plan FROM planes", sqlConn);
            SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

            while (drPlanes.Read())
            {
                Plan pl = new Plan();
                pl.ID = (int)drPlanes["id_plan"];
                pl.Descripcion = (string)drPlanes["desc_plan"];
                planes.Add(pl);
            }

            return planes;
        }

        protected void Update(Persona pers)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE personas SET nombre = @nombre, " +
                    "apellido = @apellido, direccion = @direccion, email = @email, telefono = @telefono, fecha_nac = @fecha_nac, " +
                    "legajo = @legajo, tipo_persona = @tipo_persona, id_plan = @id_plan  WHERE id_persona = @id", sqlConn);
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = pers.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = pers.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = pers.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = pers.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = pers.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = pers.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = pers.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = pers.TipoPersona;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = pers.ID;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = pers.IDPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Persona pers)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "insert into personas(nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) " +
                    "values(@nombre, @apellido, @direccion, @email, @telefono, @fecha_nac, @legajo, @tipo_persona, @id_plan)" +
                    "select @@identity", sqlConn);
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = pers.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = pers.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = pers.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = pers.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = pers.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = pers.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = pers.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = pers.TipoPersona;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = pers.ID;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = pers.IDPlan;
                pers.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

            public void Delete(int ID)
            {
                try
                {
                    this.OpenConnection();
                    SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona = @id", sqlConn);
                    cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                    cmdDelete.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    Exception ExcepcionManejada = new Exception("Error al eliminar la persona", ex);
                    throw ExcepcionManejada;
                }
                finally
                {
                    this.CloseConnection();
                }
            }

            public void Save(Persona pers)
            {
                if (pers.State == BusinessEntity.States.New)
                {
                    this.Insert(pers);
                }
                else if (pers.State == BusinessEntity.States.Deleted)
                {
                    this.Delete(pers.ID);
                }
                else if (pers.State == BusinessEntity.States.Modified)
                {
                    this.Update(pers);
                }
                pers.State = BusinessEntity.States.Unmodified;
            }
 
    }

}


