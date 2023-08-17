using Task_Management_System.Model;
using Task_Managment_API.DAO;

namespace Task_Managment_API.Services
{
    public class TaskService : ITaskService
    {
        private ITaskDAO taskDAO;

        public TaskService()
        {
            taskDAO=new TaskDAO();
        }

        public string AddTasks(Tasks t)
        {
            return taskDAO.AddTasks(t);
        }

        public string DeleteTask(int id)
        {
            return taskDAO.DeleteTask(id);
        }

        public List<Tasks> GetTasks()
        {
            return taskDAO.GetTasks();
        }

        public Tasks GetTasks(int id)
        {
            return taskDAO.GetTasks(id);
        }

        public string UpdateTask(Tasks newTask, int id)
        {
            return taskDAO.UpdateTask(newTask, id);
        }

        string ITaskService.login(User user)
        {
            return taskDAO.login(user);
        }
    }
}
