using Microsoft.EntityFrameworkCore;

using System;


using TeamBackendDemoAPI.Data;
using TeamBackendDemoAPI.Interfaces;
using TeamBackendDemoAPI.Models;


namespace TeamBackendDemoAPI.Repositories
{
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

        // ✅ Update method
        public async Task UpdateAsync(FormData data)
        {
            var existing = await _context.FormDatas.FindAsync(data.Id);
            if (existing != null)
            {
                existing.Step1Name = data.Step1Name;
                existing.Step2Email = data.Step2Email;
                existing.Step3Address = data.Step3Address;

                await _context.SaveChangesAsync();
            }
        }

        // ✅ Delete method
        public async Task DeleteAsync(int id)
        {
            var data = await _context.FormDatas.FindAsync(id);
            if (data != null)
            {
                _context.FormDatas.Remove(data);
                await _context.SaveChangesAsync();
            }
        }
    }
}

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
