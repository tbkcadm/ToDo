using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDO.Models;

namespace ToDO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ToDoContext _toDoContext;

       

        public TodoController(ToDoContext toDoContext)
        {
            _toDoContext = toDoContext;
        }

        [HttpGet]
        public List<Thing> Get()
        {
            var result = (from a in _toDoContext.Things
                          select a).ToList();
            return result;
        }
    }
}
