using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ArticleBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        public ArticleController()
        {

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return null;
        }

        [HttpGet("GetById/{Id}")]
        public async Task<IActionResult> GetById()
        {
            return null;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add()
        {
            return null;
        }

        [HttpPost("Update/{Id}")]
        public async Task<IActionResult> Update()
        {
            return null;
        }

        [HttpGet("Remove/{Id}")]
        public async Task<IActionResult> Remove()
        {
            return null;
        }
    }
}