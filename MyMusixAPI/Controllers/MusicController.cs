using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMusixAPI.Service.Domain.Models;
using MyMusixApi.Service.Domain.DTO;
//namespace MyMusixAPI.Service.Api.Controllers
namespace MyMusixAPI.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    
    public class MusicController : ControllerBase
    {
        [Route("GetAllMusicDetails")]
        [HttpGet]
        //[Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<MusicData> GetAllMusicDetails()
        {
            

            MusicManagement managementobj = new MusicManagement();

            return managementobj.GetAllMusicDetails();

        }
    }
}