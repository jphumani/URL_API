using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace URL_API_v2
{
    public class CD_MLA
    {
        private SqlConnection conn = new SqlConnection("server=JPDELL ; database=dbImportadora ; integrated security = true");
        public void InsertaMLA(tablaMLA contactos)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO URLS_API VALUES (@URL_SEARCH)";
                SqlParameter urlsearch = new SqlParameter("@URL_SEARCH", contactos.URL_QUERY);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(urlsearch);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public void EditarMLA(tablaMLA contactos)
        {
            try
            {
                conn.Open();
                string query = "UPDATE URLS_API SET URL_SEARCH = @URL_SEARCH WHERE @URL_ID = URL_ID";
                SqlParameter urlid = new SqlParameter("@URL_ID", contactos.URL_ID);
                SqlParameter urlsearch = new SqlParameter("@URL_SEARCH", contactos.URL_QUERY);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(urlid);
                command.Parameters.Add(urlsearch);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public void BorrarMLA(int URL_ID)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM URLS_API WHERE @URL_ID = URL_ID";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@URL_ID", URL_ID));

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }


        public List<tablaMLA> GetMLAs(string Buscar = null)
        {
            List<tablaMLA> list = new List<tablaMLA>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM URLS_API";
                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(Buscar))
                {
                    query += "WHERE URL_SEARCH LIKE @Buscar";
                    command.Parameters.Add(new SqlParameter("@Buscar", $"%{Buscar}%"));
                }

                command.CommandText = query;
                command.Connection= conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new tablaMLA
                    {
                        URL_ID = int.Parse(reader["URL_ID"].ToString()),
                        URL_QUERY = reader["URL_SEARCH"].ToString(),

                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
            return list;
        }
    }
}
