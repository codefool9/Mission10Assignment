using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10Assignment.Models;
using SQLitePCL;

namespace Mission10Assignment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlerRepository _repo;

        public BowlingController(IBowlerRepository temp)
        {
            _repo = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            return _repo.GetBowlers();
        }
    }
}

