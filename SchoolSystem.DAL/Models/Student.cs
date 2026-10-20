using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.DAL.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();

        public int LaptopId { get; set; }
        [ForeignKey(nameof(LaptopId))]
        public Laptop Laptop { get; set; }

    }
}
