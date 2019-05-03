using ITI.Smart.UI.EF.DBF.Models;
using ITI.Smart.UI.EF.DBF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.DBF.BLL.Mangers
{
    public class CountryManger : Repository<Country, Entities>
    {
        public CountryManger(Entities context) : base(context)
        {
        }
    }
}
