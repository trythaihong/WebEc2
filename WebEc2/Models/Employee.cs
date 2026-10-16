namespace WebEc2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FistName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Gender { get; set; }
        public string? Phone { get; set; }
    }
}
