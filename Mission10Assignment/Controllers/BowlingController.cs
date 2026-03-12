using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10Assignment.Models;

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
    }
}
