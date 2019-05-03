using ITI.Smart.UI.EF.DBF.BLL;
using ITI.Smart.UI.EF.DBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.DBF.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            App_Start.EntityFrameworkProfilerBootstrapper.PreStart();

            //Entities context = new Entities();
            //context.Countries.Add(new Country { Name = "Egypt" });
            //var x = context.SaveChanges();

            UnitOfWork u = UnitOfWork.Create();
            // Add
            //u.CountryManger.Add(new Country { Name = "USA" });

            //delete
            //Country x = u.CountryManger.GetById(1);
            //u.CountryManger.Delete(x);

            //update
            Country x = u.CountryManger.GetById(3);
            x.Name = "America";
            u.CountryManger.Update(x);


        }
    }
}

