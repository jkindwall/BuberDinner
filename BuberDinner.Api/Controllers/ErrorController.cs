﻿namespace BuberDinner.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            return Problem();
        }
    }
}
