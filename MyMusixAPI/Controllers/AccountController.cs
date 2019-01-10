using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace MyMusixAPI.Controllers
{
    using MyMusixApi.Service.Domain.models;

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        [HttpPost]
        public bool AddUser([FromBody] RegisterRequest userDetailsRequest)
        {
            var a = userDetailsRequest;
            return true;
        }

        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }


    //C:\Users\Prashob.M\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB
    //Steps to add connection:
    //1>From view use server explorer and creatre new connection use MS SQL
    //2>then select (localdb)\MSSQLLocalDB  as db and file type.
}