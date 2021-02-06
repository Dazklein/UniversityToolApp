using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StateApp.Models;
using static StateApp.Models.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StateApp.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiStudentController : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();

        // GET: api/<ApiFacultyController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            return await db.Students.Include(g => g.Group).ToListAsync();
        }

        // GET api/<ApiFacultyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiFacultyController>
        [HttpPost]
        public async Task<ActionResult<Student>> Post(Student student)
        {
            await db.Students.AddAsync(student);
            await db.SaveChangesAsync();
            return new ObjectResult(await db.Students.Include(g => g.Group).Where(x => x.StudentId == student.StudentId).FirstOrDefaultAsync());
        }

        // PUT api/<ApiFacultyController>/5
        [HttpPut]
        public async void Put(Student student)
        {
            db.Students.Update(student);
            await db.SaveChangesAsync();
        }

        // DELETE api/<ApiFacultyController>/5
        [HttpDelete]
        public async void Delete(Student student)
        {
            db.Students.Remove(student);
            await db.SaveChangesAsync();
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ApiGroupController : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Group>>> Get()
        {
            IEnumerable<Group> groups = await db.Groups.ToListAsync();
            return new ObjectResult(groups);
        }

        [HttpPost]
        public async void Post(Group group)
        {
            await db.Groups.AddAsync(group);
            await db.SaveChangesAsync();
        }

        [HttpPut]
        public async void Put(Group group)
        {
            db.Groups.Update(group);
            await db.SaveChangesAsync();
        }

        [HttpDelete]
        public async void Delete(Group group)
        {
            db.Groups.Remove(group);
            await db.SaveChangesAsync();
        }
    }
}
