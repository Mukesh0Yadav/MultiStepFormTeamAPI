using Microsoft.EntityFrameworkCore;
using TeamBackendDemoAPI.Data;
using TeamBackendDemoAPI.Interfaces;
using TeamBackendDemoAPI.Models;

namespace TeamBackendDemoAPI.Repositories;

public class FormDataRepository : IFormDataRepository
{
    private readonly AppDbContext _context;

    public FormDataRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FormData>> GetAllAsync() =>
        await _context.FormDatas.ToListAsync();

    public async Task<FormData?> GetByIdAsync(int id) =>
        await _context.FormDatas.FindAsync(id);

    public async Task AddAsync(FormData data)
    {
        _context.FormDatas.Add(data);
        await _context.SaveChangesAsync();
    }
}
