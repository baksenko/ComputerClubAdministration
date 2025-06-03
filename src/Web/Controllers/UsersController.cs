using Core.Entities;
using Infrastrucutre.Data;
using Infrastrucutre.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserRepository _repository;

    public UsersController(UserRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsersAsync([FromBody] User user)
    {
        var users = await _repository.GetAllAsync();
        
        return Ok(users);
    }
}