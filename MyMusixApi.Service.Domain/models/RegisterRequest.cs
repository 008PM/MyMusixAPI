﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyMusixAPI.Service.Domain.Models
{
    public class RegisterRequest
    {
   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
