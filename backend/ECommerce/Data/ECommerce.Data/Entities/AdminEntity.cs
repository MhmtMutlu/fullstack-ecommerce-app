﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entities
{
    public enum AuthorizationType
    {
        FullAuthority = 1,
        HalfAuthority = 2
    }

    [Table("Admins")]
    public class AdminEntity : BaseEntity
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public AuthorizationType Authorization { get; set; }
    }
}
