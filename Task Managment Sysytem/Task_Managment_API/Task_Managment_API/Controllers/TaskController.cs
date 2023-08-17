using Microsoft.AspNetCore.Mvc;

using System.Net.NetworkInformation;
using Task_Management_System.Model;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Authorization;
using Task_Managment_API.Services;
using Microsoft.Extensions.Configuration;

namespace Task_Managment_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private ITaskService _taskService;



        [AllowAnonymous]
        [HttpPost]
        public String Login(User user)
        {
            return _taskService.login(user);
        }

            public TaskController()
        {

            _taskService = new TaskService();
        }
        [HttpGet]

        public List<Tasks> GetTasks()
        {

            return _taskService.GetTasks();
        }

        [HttpPost]
        public String AddTasks(Tasks t)
        {
            return _taskService.AddTasks(t);

        }

        [HttpGet("{id}")]
        public Tasks GetTasks(int id)
        {
            return _taskService.GetTasks(id);
        }

        [HttpPut("{id}")]
        public String UpdateTask(Tasks newTask, int id)
        {
            Console.WriteLine(id);
            return _taskService.UpdateTask(newTask, id);
        }

        [HttpDelete("{id}")]
        public String DeleteTask(int id)
        {
            return _taskService.DeleteTask(id);
        }
    }
}
