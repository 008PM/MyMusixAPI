﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyMusixAPI.Service.Domain.Models
{
  public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
