using ITI.Smart.UI.EF.DBF.BLL.Mangers;
using ITI.Smart.UI.EF.DBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.DBF.BLL
{
    public class UnitOfWork
    {
        private static Entities context = new Entities();
        private static UnitOfWork unitOfWork;
        private UnitOfWork() { }

        public static UnitOfWork Create()
        {
            if (unitOfWork == null )
            {
                unitOfWork = new UnitOfWork();
            }
            return unitOfWork;
        }
        public CityManger CityManger 
        {
            get { return new CityManger(context); }
        }
        public CountryManger CountryManger
        {
            get { return new CountryManger(context); }
        }

    }
}
