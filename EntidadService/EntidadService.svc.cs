using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Diagnostics;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace EntidadService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EntidadService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EntidadService.svc o EntidadService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EntidadService : IEntidadService
    {
        private List<string> crearConeccion() {
            SqlConnection myConnection = new SqlConnection("Data Source=173.193.3.218;" +
                "Initial Catalog=ElDirectorioDb;" +
                "Integrated Security=False;" +
                "User ID=Carlos;" +
                "Password=cqcg+;" +
                "Connect Timeout=15;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False");

            SqlCommand myCommand = new SqlCommand("select * from Municipio where Deleted=0;", myConnection);
            SqlDataReader myReader;

            myConnection.Open();
           // myReader = myCommand.ExecuteReader();

       
            

            
            using (myConnection) { 
            using(myReader = myCommand.ExecuteReader()){
            while(myReader.Read()){
            ciudades.Add(Convert.ToString(myReader["Name"]));
            }
            }
            }
            myConnection.Close();
            
        }
        
        public String JSONData(string id)
        {

            String ciudades = "";
            crearConeccion(ciudades);
            
     //       Debug.WriteLine("asdasdasdds");
        //    EntidadesDAO data = new EntidadesDAO();
         //   Debug.WriteLine(data)

            return ("Pediste la entidad" + id + " ");
         
        }
    }
}
