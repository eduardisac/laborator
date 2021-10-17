using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;
//using Microsoft.Extensions.Logging;

namespace L02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        
        public StudentsController() { }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return StudentsRepo.Students;
        }
    }
}
