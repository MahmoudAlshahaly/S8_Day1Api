namespace S8_Day1Api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Department? Department { get; set; }
        public int MyProperty { get; set; }
    }
}
