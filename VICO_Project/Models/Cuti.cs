using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.Models
{
    public class Cuti
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Departemen { get; set; }
        public string Priode { get; set; }
        public string Status { get; set; }

    }
}

//, DatabaseGenerated(DatabaseGeneratedOption.Identity)