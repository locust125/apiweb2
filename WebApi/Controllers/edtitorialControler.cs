using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route ("api/[controller]")]

public class editorialController : ApiControllerBase<editorial>
{
    public editorialController(DataContext context, ILogger<editorial> logger) : base (context, logger){
        
    }
}