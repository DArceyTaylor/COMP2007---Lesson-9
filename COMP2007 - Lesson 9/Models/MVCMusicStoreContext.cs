using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace COMP2007___Lesson_9.Models
{
    public class MVCMusicStoreContext : DbContext
    {
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Album> ALbums { get; set; }
        public virtual DbSet<Song> Songs { get; set; }

    }
}