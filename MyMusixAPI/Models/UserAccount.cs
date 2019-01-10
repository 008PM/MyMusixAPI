using System;
using System.Collections.Generic;

namespace MyMusixAPI.Service.Api.Models
{
    public partial class UserAccount
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
