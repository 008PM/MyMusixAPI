using System;
using System.Collections.Generic;
using System.Text;

namespace MyMusixApi.Service.Domain.models
{
    public class RegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
