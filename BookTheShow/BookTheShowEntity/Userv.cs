using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTheShowEntity
{
    public class Userv
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UservId { get; set; }
        public string UservName { get; set; }

        public string UservEmail { get; set; }

        public string UserPassword { get; set; }
        
    }
}
