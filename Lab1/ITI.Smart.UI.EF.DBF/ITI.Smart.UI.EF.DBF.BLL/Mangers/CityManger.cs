using ITI.Smart.UI.EF.DBF.Models;
using ITI.Smart.UI.EF.DBF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.DBF.BLL.Mangers
{
    public class CityManger : Repository<City, Entities>
    {

        public CityManger(Entities context) : base(context)
        {
        }
    }
}
