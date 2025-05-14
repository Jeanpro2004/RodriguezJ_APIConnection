using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RodriguezJ_APIConnection.Repositories;
using System.Threading.Tasks;

namespace RodriguezJ_APIConnection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private CountriesRepository _repo;

        public CountriesController ()
        {
            _repo = new CountriesRepository();
        }


        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> GetCountryListAsync()
        {
            try
            {

            var countries = await _repo.GetCountryList();
                return Ok(countries);
            }
            catch  (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
