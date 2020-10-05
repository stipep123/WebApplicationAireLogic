using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAireLogic.Models
{
    public class SongDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public long NumberOfWords { get; set; }
    }
}