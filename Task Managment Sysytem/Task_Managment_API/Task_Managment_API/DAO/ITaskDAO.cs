using Task_Management_System.Model;

namespace Task_Managment_API.DAO
{
    public interface ITaskDAO
    {
        string AddTasks(Tasks t);
        string DeleteTask(int id);
        List<Tasks> GetTasks();
        Tasks GetTasks(int id);
        string login(User user);
        string UpdateTask(Tasks newTask, int id);
    }
}
