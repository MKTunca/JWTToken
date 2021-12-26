using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminJwtToken.Model;
using static AdminJwtToken.Model.DbContext;

namespace AdminJwtToken.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PanelController : ControllerBase
    {
        private readonly APIDbContext _context;

        public PanelController(APIDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll()
        {
            List<Panel> productList = new List<Panel>();

            foreach (var item in _context.Panel)
            {
                productList.Add(item);
            }

            return Ok(productList);
        }
    }
}
