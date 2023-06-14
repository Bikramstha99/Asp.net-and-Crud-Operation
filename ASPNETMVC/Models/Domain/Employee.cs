namespace ASPNETMVC.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public long Salary { get; set; }
        public DateTime DateOfTime { get; set; }
        public String Department { get; set; }
    }
}
