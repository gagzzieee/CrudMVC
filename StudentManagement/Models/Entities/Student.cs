using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string RollNumber { get; set; }

        public string CGPA { get; set; }

    }
}
