using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication3.Domain.Entities
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid ArtistId { get; set; }
        public List<Track> Traks { get; set; } = new List<Track>();
    }
}
