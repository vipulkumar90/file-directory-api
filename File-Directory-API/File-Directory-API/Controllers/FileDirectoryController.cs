using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace File_Directory_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileDirectoryController : ControllerBase
    {
        public List<FolderModel> fileDirectory = new List<FolderModel>();
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(fileDirectory);
        }
        [HttpPost]
        public ActionResult Post(int id, string name, bool isFolder)
        {
            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}
