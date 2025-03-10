using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S8_Day1Api.Models;

namespace S8_Day1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        CompanyContext _context = new CompanyContext();

        [HttpGet]
        public ActionResult GetAll()
        {
            var depts = _context.Departments.ToList();
            return Ok(depts);
        }

        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            var dept = _context.Departments.Find(Id);
            if(dept == null)
            {
                return NotFound();
            }
            return Ok(dept);
        }
        [HttpPost]
        public ActionResult Add(Department department)
        {
            _context.Add(department);
            //_context.Departments.Add(department);
            _context.SaveChanges();

            return CreatedAtAction("GetById", new { Id = department.Id } ,new {Message = "Created SuccessFully"});
        }
        [HttpPut ("{Id}")]
        public ActionResult Edit(int Id , Department department)
        {
            if(Id != department.Id)
            {
                return BadRequest();
            }

            var deptFromDataBase = _context.Departments.Find(Id);

            if(deptFromDataBase  == null )
            {
                return NotFound();
            }

            deptFromDataBase.Name = department.Name;
            deptFromDataBase.Location = department.Location;
            //_context.Departments.Update(deptFromDataBase);
            //_context.Update(deptFromDataBase);
            _context.SaveChanges();

            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            var dept = _context.Departments.Find(Id);
            _context.Departments.Remove(dept);
            //_context.Remove(dept);

            _context.SaveChanges();

            return NoContent();
        }
    }
}
