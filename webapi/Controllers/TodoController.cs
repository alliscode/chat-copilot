using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace CopilotChat.WebApi.Controllers;

/// <summary>
/// Controller responsible for handling chat messages and responses.
/// </summary>
[ApiController]
public class TodoController : ControllerBase, IDisposable
{
    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        this._logger = logger;
    }

    [HttpGet]
    [AllowAnonymous]
    [Route("/todos")]
    public IActionResult Todos()
    {
        return this.Ok(new { todos = new string[] { "buy stuff", "do stuff", "sell stuff" } });

    }

    public void Dispose()
    {
    }
}
