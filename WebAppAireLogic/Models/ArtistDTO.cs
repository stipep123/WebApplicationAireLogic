using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAireLogic.Models
{
    public class ArtistDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int NumberOfAlbums { get; set; }
        public int NumberOfSongs { get; set; }
        public float AverageNumOfWords { get; set; }
        public long MinimumWords { get; set; }
        public long MaximumWords { get; set; }
        public float ChangeByAlbum { get; set; }
    }
}
