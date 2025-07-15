using Microsoft.AspNetCore.Mvc;
using TeamBackendDemoAPI.Interfaces;
using TeamBackendDemoAPI.Models;

namespace TeamBackendDemoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FormDataController : ControllerBase
{
    private readonly IFormDataRepository _repo;

    public FormDataController(IFormDataRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _repo.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var form = await _repo.GetByIdAsync(id);
        return form == null ? NotFound() : Ok(form);
    }

    [HttpPost]
    public async Task<IActionResult> Create(FormData form)
    {
        await _repo.AddAsync(form);
        return Ok();
    }
}
