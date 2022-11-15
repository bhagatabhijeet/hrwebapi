namespace hrweb.api.Models.Domain
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateOnly HireDate { get; set; }
        public int  JobId { get; set; }
        public int Salary { get; set; }
        public Employee Manager { get; set; }
        public int DepartmentId { get; set; }

        //Navigation Properties
        public IEnumerable<Dependent> Dependents { get; set; }

    }
}
