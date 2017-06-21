using ComicBookGalleryModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel
{
    public class Context : DbContext
    {
       public Context()
        {   // Elimina y crea cada vez que el modelo cambia.
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());          
        }
        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}