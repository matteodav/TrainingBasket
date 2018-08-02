using Microsoft.AspNetCore.Mvc;
using OutOfWorkingHours.Training.Basket.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutOfWorkingHours.Training.Basket.Controllers
{
    public class LoginController : ControllerBase
    {
        private IConfiguration configuration;


        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

    
        [HttpGet]
        public IActionResult Get()
        {
            var db = configuration.DatabaseConfiguration.ConnectionString;

            throw new Exception("Error");


            //return Ok();
        }






    }
}
