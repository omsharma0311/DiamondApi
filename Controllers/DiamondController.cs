using DiamondApi.Models;
using DiamondApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondApi.Controllers
{
    public class DiamondController
    {
        [ApiController]
        [Route("[diamonds]")]
        public class MyBooksController : ControllerBase
        {
            private readonly IDiamondService _diamondService;
            public MyBooksController(IDiamondService diamondService)
            {
                _diamondService = diamondService;
            }

            [HttpGet("GetAll")]
            public IActionResult Get()
            {
                return Ok(_diamondService.GetAllDiamond());
            }

            [HttpGet("{id}")]
            public IActionResult GetSingle(int id)
            {
                return Ok(_diamondService.GetDiamondById(id));
            }

            [HttpPost]
            public IActionResult AddDiamond(Diamond newDiamond)
            {
                return Ok(_diamondService.AddDiamond(newDiamond));
            }

            [HttpPut]
            public IActionResult UpdateDiamond(Diamond updateDiamond)
            {
                return Ok(_diamondService.UpdateDiamond(updateDiamond));
            }
            [HttpDelete]
            public IActionResult DeleteDiamiond(Diamond deleteDiamond)
            {
                return Ok(_diamondService.DeleteDiamond(deleteDiamond));
            }
        }
    }
}
