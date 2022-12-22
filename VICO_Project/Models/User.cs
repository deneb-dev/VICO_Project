using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.Models
{
    public class User
    {
        [Key]
        [ForeignKey("Employee")]
        public int Id { get; set; }
        public string Password { get; set; }
        public Cuti cuti { get; set; }
        [ForeignKey("Cuti")]
        public int id_Cuti { get; set; }

        public Employee Employee { get; set; }
        public int id_Employee { get; set; }
    }
}
