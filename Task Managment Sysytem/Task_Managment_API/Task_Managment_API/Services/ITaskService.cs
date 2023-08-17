using Task_Management_System.Model;

namespace Task_Managment_API.Services
{
    public interface ITaskService
    {
        string AddTasks(Tasks t);
        string DeleteTask(int id);
        List<Tasks> GetTasks();
        Tasks GetTasks(int id);
        string UpdateTask(Tasks newTask, int id);

        string login(User user);
    }
}
