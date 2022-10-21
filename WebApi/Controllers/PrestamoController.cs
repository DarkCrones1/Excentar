using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route ("api/[controller]")]

public class PrestamosController : ApiControllerBase<Prestamos>
{
    public PrestamosController(DataContext context, ILogger<Prestamos> logger) : base (context, logger){
        
    }
}