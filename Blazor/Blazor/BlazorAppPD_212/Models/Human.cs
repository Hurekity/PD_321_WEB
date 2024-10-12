using System.ComponentModel.DataAnnotations;

namespace BlazorPD_321.Models
{
    public class Human
    {
        [Key]
        public int teacher_id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public DateTime birth_date { get; set; }
    }
}
