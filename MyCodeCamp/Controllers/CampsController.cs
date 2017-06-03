﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCodeCamp.Controllers
{
    [Route("api/[controller]")]
    public class CampsController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(new { Name = "Yusuf", FavoriteColor = "Blue" });
        }
    }
}
