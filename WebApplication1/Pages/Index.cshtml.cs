using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public StudentDetailsService StudentDetailsService;
        public IEnumerable<Student> Students { get; private set; }
        public Student StudentDetails { get; private set; }

        [BindProperty]
        public string name { get; set; }
        public IndexModel(
            ILogger<IndexModel> logger,
            StudentDetailsService StudentService)
        {
            _logger = logger;
            StudentDetailsService = StudentService;
        }
        public void OnGet()
        {
            Students = StudentDetailsService.GetStudents();
        }

        public void GetDetails()
        {
            StudentDetails = StudentDetailsService.GetDetailsOfStudent(name);
        }
    }
}