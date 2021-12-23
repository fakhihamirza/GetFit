using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class WriteHistory
    {
        [ForeignKey("User")]
        public int UserID { get; set; }
        public string food_name { get; set; }

    }
}
