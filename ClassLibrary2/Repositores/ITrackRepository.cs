using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Domain.Dto;

namespace WebApplication3.Domain.Repositores
{
    public interface ITrackRepository
    {
        Task<List<TrackDto>> GetAllAsync();
        Task<TrackDto> GetByIdAsync(Guid id);
        Task<TrackDto> CreateAsync(TrackDto item);
        Task<bool> UpdateAsync(TrackDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}
