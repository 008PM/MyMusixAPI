using System;
using System.Collections.Generic;
using System.Text;
using MyMusixAPI.Service.Domain.Models;
using MyMusixAPI.Service.Api.DTO;
using System.Linq;
using System.Data.Entity;

namespace MyMusixApi.Service.Domain.DTO
{
   

    public class MusicManagement 
    {
        public IEnumerable<MusicData> GetAllMusicDetails()
        {
          //Db data is Iqueryable type
          MyMusiXContext context = new MyMusiXContext();
          //MusicData from Db has all the details of the music to be put on the Music page
         var MusicDataFromDb = context.MusicData.AsNoTracking();
         return MusicDataFromDb;
        }
    }
}
