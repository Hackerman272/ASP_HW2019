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
    public class ArtistRepository: IArtistRepository
    {
        private readonly MusicContext _context;

        public ArtistRepository(MusicContext context)
        {
            _context = context;
        }

        public async Task<List<ArtistDto>> GetAllAsync()
        {
            return ArtistConverter.Convert(await _context.Artist.ToListAsync());
        }

        public async Task<ArtistDto> GetByIdAsync(Guid id)
        {
            return ArtistConverter.Convert(await _context.Artist.FindAsync(id));
        }
        public async Task<ArtistDto> CreateAsync(ArtistDto item)
        {
            var result = _context.Artist.Add(ArtistConverter.Convert(item));
            await _context.SaveChangesAsync();
            return ArtistConverter.Convert(result.Entity);
        }
        public async Task<bool> UpdateAsync(ArtistDto item)
        {
            if (item == null)
                return false;
            _context.Artist.Update(ArtistConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var artist = await _context
                .Artist
                .FindAsync(id);
            if (artist == null)
                return false;
            _context.Artist.Remove(artist);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
