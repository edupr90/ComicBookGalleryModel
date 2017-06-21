﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel.Model
{
    public class ComicBookArtits
    {
        public int Id { get; set; }
        public int ComicBookI { get; set; }
        public int ArtistId { get; set; }
        public int RoleId { get; set; }

        public ComicBook ComicBook { get; set; }
        public Artist Artist { get; set; }
        public Role Role { get; set; }

    }
}
