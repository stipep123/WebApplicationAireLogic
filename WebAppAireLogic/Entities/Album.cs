using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAireLogic.Entities
{
    public class Album
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public virtual IList<Song> Songs { get; set; }
    }
}
