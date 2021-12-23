using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserHistory
    {
        [ForeignKey("User")]
        public int UserID { get; set; }
        [Required]
        public DateTime Posted_At = DateTime.Now;
        [Required]
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int food_id { get; set; }
        [Required]
        public string food_name { get; set; }

    }
}
