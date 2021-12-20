using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class Login_user
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string password { get; set; }
    }
}
