using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.CodeFirst.Models
{
    public class Cover
    {
        public int Id { get; set; }
        public String Code { get; set; }

        public Book Book { get; set; }
    }
}
