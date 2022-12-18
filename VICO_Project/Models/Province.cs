using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.Models
{
    public class Province
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Region Region { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }


    }
}

//, DatabaseGenerated(DatabaseGeneratedOption.Identity)