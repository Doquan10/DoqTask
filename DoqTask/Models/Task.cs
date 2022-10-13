using System.ComponentModel.DataAnnotations;

namespace DoqTask.Models
{
    public class Task
    {
        [Key]
        public int id { get; set; }

        public string task_title { get; set; }

        public string task_description { get; set; }

        public string task_status { get; set; }

        public string? task_date { get; set; }

    }
}
