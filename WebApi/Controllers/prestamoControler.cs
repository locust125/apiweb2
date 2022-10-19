using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route ("api/[controller]")]

public class prestamoController : ApiControllerBase<prestamo>
{
    public prestamoController(DataContext context, ILogger<prestamo> logger) : base (context, logger){
        
    }
}