using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController, Route ("api/[controller]")]
public class clienteController : ApiControllerBase<cliente>
{
    public clienteController(DataContext context, ILogger<cliente> logger) : base(context, logger)
    {
            
    }
}