using VICO_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.Repositories.Interface
{
    public interface IProvinceRepository
    {   
        List<Province> Get();

        Province Get( int id ,Province province);

        
        int Post(Province province);

      
        int Put(int id, Province province);

      
        int Delete(Province province);
    }
}
