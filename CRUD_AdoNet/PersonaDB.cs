using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace CRUD_AdoNet
{
    public class PersonaDB
    {
        private string connectionString = "Data source=YASMIN-PC\\SQLEXPRESS; Initial catalog=CrudWindowsForm; Integrated Security=True;";

        /*
        public bool Ok()
        {
            try
            {
                //SqlConnection = clase
                //aca me conecto a la bdd
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }*/

        ///metodo que devuelve una lista de personas:
        public List<Persona> Get()
        {
            List<Persona> persona = new List<Persona>();
            //ahora lleno la lista
            string query = "SELECT id, nombre, apellido, edad FROM Persona";


            //using para abrir y cerrar la conexion:
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    //abro la conexion:
                    connection.Open();
                    //utilizo el objeto SqlDataReader para LEER = lo ejecuto
                    SqlDataReader reader = command.ExecuteReader();

                    //este devuelve un true siempre y cuando todavia exista un registro
                    while (reader.Read())
                    {
                        //instancio un obj de la clase Persona
                        Persona persona1 = new Persona();
                        persona1.Id = reader.GetInt32(0);
                        persona1.Nombre = reader.GetString(1);
                        persona1.Apellido = reader.GetString(2);
                        persona1.Edad = reader.GetInt32(3);

                        //agregamos el objeto a la lista que creamos en un inicio
                        persona.Add(persona1);
                    }
                    //cierro reader y conexion
                    reader.Close();
                    connection.Close();
                }

                catch(Exception ex) 
                {
                    throw new Exception("hay un error en la bdd" + ex.Message);
                }
            }
            return persona;
        }

        //metodo que devuelve una persona
        public Persona Get(int id)
        {

            //busco la persona
            string query = "SELECT id, nombre, apellido, edad FROM Persona where id=@id";


            //using para abrir y cerrar la conexion:
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    //abro la conexion:
                    connection.Open();
                    //utilizo el objeto SqlDataReader para LEER = lo ejecuto
                    SqlDataReader reader = command.ExecuteReader();

                    //este devuelve un true siempre y cuando todavia exista un registro
                    reader.Read();
                    
                    //instancio un obj de la clase Persona
                    Persona persona1 = new Persona();
                    persona1.Id = reader.GetInt32(0);
                    persona1.Nombre = reader.GetString(1);
                    persona1.Apellido = reader.GetString(2);
                    persona1.Edad = reader.GetInt32(3);

                    //cierro reader y conexion
                    reader.Close();
                    connection.Close();
                    return persona1;
                }

                catch (Exception ex)
                {
                    throw new Exception("hay un error en la bdd" + ex.Message);
                }
            }
        }


        //metodo para agregar a la tabla Persona
        public void Add(string nombre, string apellido, int edad)
        {
            string query = "INSERT INTO Persona(nombre, apellido, edad) VALUES (@nombre, @apellido, @edad)";

            //using, el mismo del metodo Get()
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@edad", edad);

                try
                {
                    //abro la conexion:
                    connection.Open();
                    //ejecuto el objeto
                    command.ExecuteNonQuery();

                    //cierro conexion
                    connection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("hay un error en la bdd" + ex.Message);
                }
            }
        }

        //agrego int xq recibe un int para encontrar el registro (WHERE), antes de actualizar
        public void Update(string nombre, string apellido, int edad, int id)
        {
            string query = "UPDATE Persona SET nombre=@nombre, apellido=@apellido, edad=@edad WHERE id=@id ";

            //using, el mismo del metodo Get()
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@edad", edad);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    //abro la conexion:
                    connection.Open();
                    //ejecuto el objeto
                    command.ExecuteNonQuery();

                    //cierro conexion
                    connection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("hay un error en la bdd" + ex.Message);
                }
            }
        }
        public void Delete(int id)
        {
            string query = "DELETE FROM Persona WHERE id=@id ";

            //using, el mismo del metodo Get()
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    //abro la conexion:
                    connection.Open();
                    //ejecuto el objeto
                    command.ExecuteNonQuery();

                    //cierro conexion
                    connection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("hay un error en la bdd" + ex.Message);
                }
            }
        }
    }
    public class Persona
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

    }
}
