using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication3.Domain.Entities
{
    public class Track
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid AlbumId { get; set; }
    }
}
