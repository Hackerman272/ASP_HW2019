using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Domain.Dto;

namespace WebApplication3.Domain.Repositores
{
    public interface IArtistRepository
    {
        Task<List<ArtistDto>> GetAllAsync();
        Task<ArtistDto> GetByIdAsync(Guid id);
        Task<ArtistDto> CreateAsync(ArtistDto item);
        Task<bool> UpdateAsync(ArtistDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}
