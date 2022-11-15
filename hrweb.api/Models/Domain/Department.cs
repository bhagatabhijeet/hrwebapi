namespace hrweb.api.Models.Domain
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set;}
        public Location Location { get; set;}

        //Navigation Properties
        public IEnumerable<Employee> Employees { get; set; }
    }
}
