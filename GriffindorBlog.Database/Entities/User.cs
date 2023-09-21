﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffindorBlog.Database.Entities
{
   public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }



        public Role Role { get; set; }
        public List<Article> Article { get; set; }


    }
}
