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
    public class CutiRepository : ICutiRepository
    {
        MyContext myContext;

        public CutiRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        

        public List<Cuti> Get()
        {
            var data = myContext.Cutis.ToList();
            return data;
        }

        public Cuti Get(int id)
        {
            var data = myContext.Cutis.FirstOrDefault();
            return data;
        }

        public Cuti Get(int id, Cuti cuti)
        {
            throw new NotImplementedException();
        }

        public int Post(Cuti cuti)
        {
            myContext.Cutis.Add(cuti);
            var result = myContext.SaveChanges();
            if (result > 0)
                return result;
            return 0;
        }

        public int Put(int Id, Cuti cuti)
        {
            var data = myContext.Cutis.Find(Id);
            myContext.Cutis.Update(data);
            //data.Name = cuti.Name;
            //data.Departemen = cuti.Departemen;
            //data.Priode = cuti.Priode;
            data.Status = cuti.Status;
            var result = myContext.SaveChanges();
            return result;
        }

        public int Delete(Cuti cuti)
        {
            myContext.Cutis.Remove(cuti);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
