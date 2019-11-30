using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Desarrollo_Web_MVC_Pelicula.Web.Models
{
    public class RegistroPelicula
    {
        private SqlConnection con;

        //Conectar a la base de datos
        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
            con = new SqlConnection(constr);
        }

        //Grabar un registro en la base de datos
        public int GrabarPelicula(Pelicula pelicula)
        {
            Conectar();
            SqlCommand command = new SqlCommand("Insert Into TBL_PELICULA (Titulo, Director, AutorPrincipal, No_Actores, Duracion, Estreno)"
                + "Values(@Titulo, @Director, @AutorPrincipal, @No_Actores, @Duracion, @Estreno)", con);

            command.Parameters.Add("@Titulo", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@Director", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@AutorPrincipal", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@No_Actores", System.Data.SqlDbType.Int);
            command.Parameters.Add("@Duracion", System.Data.SqlDbType.Float);
            command.Parameters.Add("@Estreno", System.Data.SqlDbType.Int);

            command.Parameters["@Titulo"].Value = pelicula.Titulo;
            command.Parameters["@Director"].Value = pelicula.Director;
            command.Parameters["@AutorPrincipal"].Value = pelicula.AutorPrincipal;
            command.Parameters["@No_Actores"].Value = pelicula.NumAutores;
            command.Parameters["@Duracion"].Value = pelicula.Duracion;
            command.Parameters["@Estreno"].Value = pelicula.Estreno;

            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            return i;
        }


        //Listar las peliculas registradas
        public List<Pelicula> ListarPeliculas()
        {
            Conectar();
            List<Pelicula> peliculas = new List<Pelicula>();
            SqlCommand command = new SqlCommand("Select Codigo, Titulo, Director, AutorPrincipal, No_Actores, Duracion, Estreno From TBL_PELICULA", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Pelicula pelicula = new Pelicula
                {
                    Codigo = int.Parse(reader["Codigo"].ToString()),
                    Titulo = reader["Titulo"].ToString(),
                    Director = reader["Director"].ToString(),
                    AutorPrincipal = reader["AutorPrincipal"].ToString(),
                    NumAutores = int.Parse(reader["No_Actores"].ToString()),
                    Duracion = double.Parse(reader["Duracion"].ToString()),
                    Estreno = int.Parse(reader["Estreno"].ToString())
                };
                peliculas.Add(pelicula);
            }
            con.Close();
            return peliculas;
        }

        //Recuperar un Registro especifico de la DB
        public Pelicula Detail(int codigo)
        {
            Conectar();
            SqlCommand command = new SqlCommand("Select Codigo, Titulo, Director, AutorPrincipal, No_Autores, Duracion, Estreno"
                + "From TBL_PELICULA WHERE Codigo = @codigo", con);

            command.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            command.Parameters["@codigo"].Value = codigo;
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            Pelicula pelicula = new Pelicula();
            if (reader.Read())
            {
                pelicula.Titulo = reader["Titulo"].ToString();
                pelicula.Director = reader["Director"].ToString();
                pelicula.AutorPrincipal = reader["AutorPrincipal"].ToString();
                pelicula.NumAutores = int.Parse(reader["No_Autores"].ToString());
                pelicula.Duracion = double.Parse(reader["No_Autores"].ToString());
                pelicula.Estreno = int.Parse(reader["No_Autores"].ToString());
            };
            con.Close();
            return pelicula;
        }

        //Modificar un Registro especifico de la DB
        public int Modificar(Pelicula pelicula)
        {
            Conectar();
            SqlCommand command = new SqlCommand("Update TBL_PELICULA Set Titulo = @Titulo, Director = @Director," 
                + "AutorPrincipal = @AutorPrincipal, No_Autores = @No_Autores, Duracion = @Duracion," 
                + "Estreno = @Estreno WHERE Codigo = @Codigo", con);

            command.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            command.Parameters.Add("@Titulo", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@Director", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@AutorPrincipal", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@No_Autores", System.Data.SqlDbType.Int);
            command.Parameters.Add("@Duracion", System.Data.SqlDbType.Float);
            command.Parameters.Add("@Estreno", System.Data.SqlDbType.Int);

            command.Parameters["@Titulo"].Value = pelicula.Titulo;
            command.Parameters["@Director"].Value = pelicula.Director;
            command.Parameters["@AutorPrincipal"].Value = pelicula.AutorPrincipal;
            command.Parameters["@NumAutores"].Value = pelicula.NumAutores;
            command.Parameters["@Duracion"].Value = pelicula.Duracion;
            command.Parameters["@Estreno"].Value = pelicula.Estreno;
            command.Parameters["@Codigo"].Value = pelicula.Codigo;

            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            return i;
        }

        //Borrar un Registro especifico de la DB
        public int Borrar(int codigo)
        {
            Conectar();
            SqlCommand command = new SqlCommand("Delete From TBL_PELICULA WHERE Codigo = @Codigo", con);
            command.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            command.Parameters["@Codigo"].Value = codigo;
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            return i;
        }

    }
}