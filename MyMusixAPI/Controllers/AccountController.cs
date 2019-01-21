using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MyMusixAPI.Service.Domain.Models;
using MyMusixApi.Service.Domain.DTO;

namespace MyMusixAPI.Controllers
{
    using MyMusixApi.Service.Domain.Models;

    [Route("api/[controller]")]
    [ApiController]
    
    public class AccountController : ControllerBase
    {
        
        [Route("AddUser")]
        [HttpPost]
        
        public bool AddUser([FromBody] RegisterRequest userDetailsRequest)
        {

            var RegistrationData= userDetailsRequest;

            AccountManagement regobj = new AccountManagement();


            return regobj.UserRegistration(RegistrationData);

        }
//-------------------------->>>User--->>Login<<<-----------------------
        [Route("UserLogin")]
        [HttpPost]

        //------------------->>>To be changed soon<<-------------//
        public bool UserLogin([FromBody] LoginRequest logindetails)
        {

            var loginData = logindetails;

            AccountManagement logobj = new AccountManagement();


            return logobj.UserLogging(loginData);

        }
        //-------------------------->>>User--->>Details<<<-----------------------
       
        [HttpGet]
        [Route("GetUserDetails/{email}")]
        public UserAccount GetUserDetails(string email)
        {
            AccountManagement logobj1 = new AccountManagement();

            return logobj1.GetuserDetails(email);
        }

        //--------------->>>Edit User--------------->>
        [HttpPut]
        [Route("/EditUser")]
        public bool EditUser([FromBody] UserAccount user)
        {
            AccountManagement logobj2 = new AccountManagement();
            return logobj2.UpdateUser(user);
        }
    }    
}

//C:\Users\Prashob.M\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB
//Steps to add connection:
//1>From view use server explorer and creatre new connection use MS SQL
//2>then select (localdb)\MSSQLLocalDB  as db and file type.