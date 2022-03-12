using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Memberships
{
    public class Membership
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        [Required]
        public double Cost { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public int Duration { get; set; }
    }
}
