﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class DetailsController : ControllerBase
    {
        public StudentDetailsService StudentService { get; }

        public DetailsController(StudentDetailsService studentService)
        {
            this.StudentService = studentService;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return StudentService.GetStudents();
        }

        [Route("getdetails")]
        [HttpGet]
        public Student GetDetails([FromQuery] string name)
        {
            return StudentService.GetDetailsOfStudent(name);
        }
    }
}
