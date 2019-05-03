using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.CodeFirst.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public List<City> Cities { get; set; }

        //[ForeignKey("Passport")]
        //public int PassId { get; set; }
        //[Required]
        //public Passport Passport { get; set; }

    }
}
