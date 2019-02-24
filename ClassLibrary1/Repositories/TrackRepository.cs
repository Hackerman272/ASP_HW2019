using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Core.EF;
using WebApplication3.Domain.Converters;
using WebApplication3.Domain.Dto;
using WebApplication3.Domain.Repositores;

namespace WebApplication3.Core.Repositories
{
    class TrackRepository: ITrackRepository
    {
        private readonly MusicContext _context;

        public TrackRepository(MusicContext context)
        {
            _context = context;
        }

        public async Task<List<TrackDto>> GetAllAsync()
        {
            return TrackConverter.Convert(await _context.Tracks.ToListAsync());
        }

        public async Task<TrackDto> GetByIdAsync(Guid id)
        {
            return TrackConverter.Convert(await _context.Tracks.FindAsync(id));
        }
        public async Task<TrackDto> CreateAsync(TrackDto item)
        {
            var result = _context.Tracks.Add(TrackConverter.Convert(item));
            await _context.SaveChangesAsync();
            return TrackConverter.Convert(result.Entity);
        }
        public async Task<bool> UpdateAsync(TrackDto item)
        {
            if (item == null)
                return false;
            _context.Tracks.Update(TrackConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var track = await _context
                .Tracks
                .FindAsync(id);
            if (track == null)
                return false;
            _context.Tracks.Remove(track);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
