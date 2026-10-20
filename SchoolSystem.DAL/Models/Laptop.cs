using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.DAL.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Model{ get; set; }

        public Student Student { get; set; }
    }
}
