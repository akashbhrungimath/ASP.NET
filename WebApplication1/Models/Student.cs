using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class Student
    {
        public string Name { get; set; }

        [JsonPropertyName("USN")]
        public string Usn { get; set; }
        public string Cgpa { get; set; }

        [JsonPropertyName("fee_Status")]
        public string fee { get; set; }
        public string Gender { get; set; }

        [JsonPropertyName("Back_logs")]
        public string Backs { get; set; }
    }
}
