namespace hrweb.api.Models.Domain
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobTItle { get; set; }
        public int MinSalary { get; set; }
        public string MaxSalary { get; set; }
        //Navigation Properties
        public IEnumerable<Employee> Employees { get; set; }
    }
}
