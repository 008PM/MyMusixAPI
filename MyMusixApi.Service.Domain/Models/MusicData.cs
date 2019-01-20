using System;
using System.Collections.Generic;

namespace MyMusixAPI.Service.Domain.Models
{
    public partial class MusicData
    {
        public int Mid { get; set; }
        public string MusicName { get; set; }
        public string ArtistName { get; set; }
        public string Genere { get; set; }
        public int Cost { get; set; }
    }
}
