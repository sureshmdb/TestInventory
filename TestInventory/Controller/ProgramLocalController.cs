using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.BusinessServices.Interfaces;
using Inventory.DTO;
using Microsoft.AspNetCore.Mvc;

namespace TestInventory.Api.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProgramLocalController : ControllerBase
    {
        private readonly IProgramLocalService programLocalService;

        public ProgramLocalController(IProgramLocalService localService)
        {
            programLocalService = localService;
        }

        [HttpPost("localprogramview")]
        public async Task<IActionResult> GetLocalProgramView(ProgramLocalDto programLocalRequest)
        {
            var values = await programLocalService.GetProgramLocals(programLocalRequest);
            return Ok(values);
        }

    }
}