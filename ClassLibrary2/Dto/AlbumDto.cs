using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication3.Domain.Dto
{
    public class AlbumDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid ArtistId { get; set; }
        public List<TrackDto> Traks { get; set; } = new List<TrackDto>();
        public string ArtistName { get; set; }
    }
}
