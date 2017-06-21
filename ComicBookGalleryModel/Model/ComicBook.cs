using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel.Model
{
    public class ComicBook
    {
        public ComicBook()
        {
            Artists = new List<ComicBookArtits>();
        }

        public int Id { get; set; }
        public int SeriesId { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal? AverageRating { get; set; }

        public Series Series { get; set; }
        public ICollection<ComicBookArtits> Artists { get; set; }
        
        public string DisplayText
        {
            get
            {
                return $"{Series?.Title} #{IssueNumber}";
            }
        }
        public void AddArtist(Artist artist, Role role)
        {
            Artists.Add(new ComicBookArtits()
            {
                Artist = artist,
                Role = role
            });
        }
    }
}
