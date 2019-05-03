using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.CodeFirst.Models
{
    public class Country
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public List<City> Cities { get; set; }
    }
}
