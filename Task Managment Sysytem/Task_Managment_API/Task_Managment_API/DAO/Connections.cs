using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Task_Managment_API.DAO
{
    public class Connections
    {
      private static SqlConnection con;

        public  static SqlConnection GetConnection (){
             con = new SqlConnection("server=localhost;database=TaskManagmentSystem;trusted_connection=true;");
           
            return con;
        }
    }
}
