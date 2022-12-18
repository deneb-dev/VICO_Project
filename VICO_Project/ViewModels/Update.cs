using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.ViewModels
{
    public class Update
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string OldPw { get; set; }

        public string NewPw { get; set; }
    }
}
