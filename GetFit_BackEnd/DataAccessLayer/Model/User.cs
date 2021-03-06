using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer
{
    public class User
    {
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public List<UserHistory> user_history { get; set; }
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string password { get; set; }
    }
}
