using CkTrans.Model.Data;
using CkTrans.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CkTrans.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly CkTransContext _context;

        public WeatherForecastController(CkTransContext context)

        {
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<List<Factura>> Get()
        {
        return    await _context.Facturas.OrderByDescending(x=>x.Fecha).Take(50).ToListAsync();
             
        }
    }
}