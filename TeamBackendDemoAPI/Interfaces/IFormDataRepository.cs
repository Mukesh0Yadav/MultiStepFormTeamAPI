using TeamBackendDemoAPI.Models;


namespace TeamBackendDemoAPI.Interfaces
{
    public interface IFormDataRepository
    {
        Task<IEnumerable<FormData>> GetAllAsync();
        Task<FormData?> GetByIdAsync(int id);
        Task AddAsync(FormData data);

        // 👇 Added for Update & Delete
        Task UpdateAsync(FormData data);
        Task DeleteAsync(int id);
    }
}

namespace TeamBackendDemoAPI.Interfaces;

public interface IFormDataRepository
{
    Task<IEnumerable<FormData>> GetAllAsync();
    Task<FormData?> GetByIdAsync(int id);
    Task AddAsync(FormData data);
}

