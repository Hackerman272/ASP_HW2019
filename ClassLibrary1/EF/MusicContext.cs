using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication3.Domain.Entities;

namespace WebApplication3.Core.EF
{
    public class MusicContext: DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public MusicContext(DbContextOptions<MusicContext> opt): base(opt)
        {
            Database.EnsureCreated();
        }
    }
}
