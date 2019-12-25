using ZPMC_MES.Api.Entities;
using ZPMC_MES.Api.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ZPMC_MES.Api.Controllers.api.v2
{
    /// <summary>
    /// 
    /// </summary>
    //[CustomAuthorize]
    [Route("api/v2/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ZPMC_MESDbContext _dbContext;
        public UserController(ZPMC_MESDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult List()
        {
            using (_dbContext)
            {
                var list = _dbContext.DncUser.ToList();
                var response = ResponseModelFactory.CreateInstance;
                response.SetData(list);
                return Ok(response);
            }
        }
    }
} 