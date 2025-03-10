namespace S8_Day1Api.Models
{
    public class Department
    {
        public int Id { get; set; }
        public int MyProperty3 { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int MyProperty2 { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
    }
}
