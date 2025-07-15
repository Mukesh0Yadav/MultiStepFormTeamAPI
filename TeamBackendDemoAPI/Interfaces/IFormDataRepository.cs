using TeamBackendDemoAPI.Models;

namespace TeamBackendDemoAPI.Interfaces;

public interface IFormDataRepository
{
    Task<IEnumerable<FormData>> GetAllAsync();
    Task<FormData?> GetByIdAsync(int id);
    Task AddAsync(FormData data);
}
