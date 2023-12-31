﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "user";

        public bool IsBan { get; set; } = false;
        public bool TemporaryBan { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
    }
}
