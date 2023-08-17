using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management_System.Model
{

    public class Tasks
    {
        //  `Id`, `Title`, `Description`, `DueDate`, and `IsCompleted`.
      
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Title { get; set; }
        [Required]
        [StringLength(100)]
        public string? Description { get; set; }
        
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public Boolean IsCompleted { get; set; }

        public Tasks(int id, string title, string description, DateTime dueDate, Boolean isCompleted)
        {
            Id= id;
            Title= title;   
            Description= description;
                DueDate= dueDate;
            IsCompleted = isCompleted;
        }

        public Tasks() { }

        




    }
}
