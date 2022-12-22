using VICO_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.Repositories.Interface
{
    public interface ICutiRepository
    {   
        List<Cuti> Get();

        Cuti Get( int id ,Cuti cuti);

        
        int Post(Cuti cuti);

      
        int Put(int id, Cuti cuti);

      
        int Delete(Cuti cuti);
    }
}
