using System.Data;
using Task_Management_System.Model;
using Task_Management_System.Model;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace Task_Managment_API.DAO
{
    public class TaskDAO : ITaskDAO
    {
      private  SqlConnection con;
        public TaskDAO()
        {
             con = Connections.GetConnection();
            con.Open();
        }
        public List<Tasks> GetTasks()
        {

            List<Tasks> taskslist = new List<Tasks>();
          
            string query = "SELECT  * FROM  TasksTable ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int Id = int.Parse(dt.Rows[i]["Id"].ToString());
                string tilte = dt.Rows[i]["Title"].ToString();
                string des = dt.Rows[i]["Description"].ToString();
                DateTime duesate = DateTime.Parse(dt.Rows[i]["DueDate"].ToString());
                Boolean IsCompleted = Convert.ToBoolean(dt.Rows[i]["IsCompleted"].ToString());
                Tasks t = new Tasks(Id, tilte, des, duesate, IsCompleted);
                taskslist.Add(t);

            }
            
            return taskslist;
        }
       

        public string AddTasks(Tasks t)
        {
            
           // Console.WriteLine(t.DueDate);
            string query = "insert into TasksTable(Title,Description,DueDate,IsCompleted) values( '" + t.Title + "','" + t.Description + "','" + t.DueDate + "','" + t.IsCompleted + "')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            con.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                return "Added Successfully";
            }
            else

                return "Data can not Add in DB";

        }


        public Tasks GetTasks(int id)
        {
           

            string query = "SELECT  * FROM  TasksTable where id='" + id + "' ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

           
            int Id = int.Parse(dt.Rows[0]["Id"].ToString());
            string tilte = dt.Rows[0]["Title"].ToString();
            string des = dt.Rows[0]["Description"].ToString();
            DateTime duesate = DateTime.Parse(dt.Rows[0]["DueDate"].ToString());
            Boolean IsCompleted = Convert.ToBoolean(dt.Rows[0]["IsCompleted"].ToString());
            Tasks t = new Tasks(Id, tilte, des, duesate, IsCompleted);
            Console.WriteLine(t.Description);
            return t;
        }
        public String UpdateTask(Tasks newTask, int id)
        {
            Console.WriteLine(newTask.DueDate);
       
            string query = "update TasksTable set Title ='"+newTask.Title+"',Description='"+newTask.Description+"',DueDate='"+newTask.DueDate+"', IsCompleted='" + newTask.IsCompleted + "' where Id= " + id;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
         
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                
                return "Updated Successfully";
            }
            else
                return "Data can not Updated in DB";
        }

        public String DeleteTask(int id)
        {
           

            string query = "Delete from TasksTable where id='" + id + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
          
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                return "Deleted Successfully";
            }
            else
                return "Data can not Delete from DB";
        }

        string ITaskDAO.login(User user)
        {
            string query = "SELECT  * FROM  Login where username='" + user.username + "',password='" + user.password + "' ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


           
            string tilte = dt.Rows[0]["username"].ToString();
            string des = dt.Rows[0]["password"].ToString();
   
            User t = new User();
            
            return t;
        }
    }
}
