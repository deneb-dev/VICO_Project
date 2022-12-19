using Microsoft.EntityFrameworkCore;
using VICO_Project.Context;
using VICO_Project.Models;
using VICO_Project.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.Repositories.Data
{
    public class ProvinceRepository : IProvinceRepository
    {
        MyContext myContext;

        public ProvinceRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        

        public List<Province> Get()
        {
            var data = myContext.Provinces.ToList();
            return data;
        }

        public Province Get(int id)
        {
            var data = myContext.Provinces.FirstOrDefault();
            return data;
        }

        public Province Get(int id, Province province)
        {
            throw new NotImplementedException();
        }

        public int Post(Province province)
        {
            myContext.Provinces.Add(province);
            var result = myContext.SaveChanges();
            if (result > 0)
                return result;
            return 0;
        }

        public int Put(int id, Province province)
        {
            var data = myContext.Provinces.Find(id);
            data.Departemen = province.Departemen;
            data.Priode = province.Priode;
            data.Status = province.Status;
            myContext.Provinces.Update(data);
            var result = myContext.SaveChanges();
            return result;
        }

        public int Delete(Province province)
        {
            myContext.Provinces.Remove(province);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
