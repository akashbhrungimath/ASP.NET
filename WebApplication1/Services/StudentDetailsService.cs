using System.Text.Json;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class StudentDetailsService
    {
        public StudentDetailsService(IWebHostEnvironment webHostEnvironment) 
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        private string Students
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "students.json"); }
        }
        public IEnumerable<Student> GetStudents()
        {
            using (var fileReader = File.OpenText(Students))
            {
                return JsonSerializer.Deserialize<Student[]>(fileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
        public Student GetDetailsOfStudent(string name)
        {
            var StudentList = GetStudents();
            return (StudentList.First(student => student.Name == name));
        }
    }
}
