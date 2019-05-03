using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.CodeFirst.Models
{
    public class Passport
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public String PassUserName { get; set; }
        [Required]
        [MaxLength(30)]
        public String Nationality { get; set; }

        [ForeignKey("User")]
        public int PassUserId { get; set; }
        public User User { get; set; }
    }
}
