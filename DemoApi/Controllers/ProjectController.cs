using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoApi.DBContext;
using DemoApi.Models;

namespace SalesOrderAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectContoller : ControllerBase
{
    private readonly ProjectDbContext _context;

    public ProjectContoller(ProjectDbContext context)
    {
        this._context = context;
    }

    [HttpGet("GetProjects")]
    public async Task<List<Project>> GetProducts()
    {
        return await _context.Projects.ToListAsync();
    }

    [HttpGet("GetProductById")]
    public async Task<ActionResult<Project>> GetProductById(int projectId)
    {
        var project = await _context.Projects.FindAsync(projectId);


        if (project == null)
        {
            return NotFound();
        }

        return project;
    }
}
