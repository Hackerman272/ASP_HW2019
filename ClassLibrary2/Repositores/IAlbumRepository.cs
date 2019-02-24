using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Domain.Dto;

namespace WebApplication3.Domain.Repositores
{
    public interface IAlbumRepository
    {
        // Репозиторий - всегда работа с БД
        Task<List<AlbumDto>> GetAllAsync();
        Task<AlbumDto> GetByIdAsync(Guid id);
        Task<AlbumDto> CreateAsync(AlbumDto item);
        Task<bool> UpdateAsync(AlbumDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}
