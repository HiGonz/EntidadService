using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
namespace EntidadService
{
    public class EntidadesDAO
    {
        
       
        static void Main(string[] args)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=173.193.3.218;"+
                "Initial Catalog=ElDirectorioDb;"+
                "Integrated Security=False;"+
                "User ID=Carlos;"+
                "Password=yura1713;"+
                "Connect Timeout=15;"+
                "Encrypt=False;"+
                "TrustServerCertificate=False");
        
            try
            {
              //  myConnection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select MunicipioId from Municipio where deleted=0;", myConnection);

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Debug.WriteLine(myReader["MunicipioId"].ToString());
                }

                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }
    }

}