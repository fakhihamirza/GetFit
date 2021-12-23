using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GetFitApp.Models
{
    public class UserHistory
    {
        public int UserID { get; set; }
        [Required]
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int food_id { get; set; }
        public string food_name { get; set; }
    }
}
