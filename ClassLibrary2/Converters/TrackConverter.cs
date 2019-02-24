using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication3.Domain.Dto;
using WebApplication3.Domain.Entities;

namespace WebApplication3.Domain.Converters
{
    public static class TrackConverter
    {
        public static Track Convert(TrackDto track)
        {
            return new Track
            {
                Title = track.Title,
                Id = track.Id,
                AlbumId = track.AlbumId
            };
        }

        public static TrackDto Convert(Track track)
        {
            return new TrackDto
            {
                Title = track.Title,
                Id = track.Id,
                AlbumId = track.AlbumId
            };
        }

        public static List<Track> Convert(List<TrackDto> tracks)
        {
            return tracks.Select(a => Convert(a)).ToList();
        }
        public static List<TrackDto> Convert(List<Track> tracks)
        {
            return tracks.Select(a => Convert(a)).ToList();
        }
    }
}
