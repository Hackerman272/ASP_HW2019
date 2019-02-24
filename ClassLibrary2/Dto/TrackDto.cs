using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication3.Domain.Dto
{
    public class TrackDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid AlbumId { get; set; }
    }
}
