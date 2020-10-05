using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAireLogic.Entities
{
    public class Artist
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IList<Album> Albums { get; set; }
    }
}
