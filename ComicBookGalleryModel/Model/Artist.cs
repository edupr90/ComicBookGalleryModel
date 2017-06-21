using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel.Model
{
    public class Artist
    {
        public Artist()
        {
            ComicBooks = new List<ComicBookArtits>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ComicBookArtits> ComicBooks { get; set; }
    }
}
