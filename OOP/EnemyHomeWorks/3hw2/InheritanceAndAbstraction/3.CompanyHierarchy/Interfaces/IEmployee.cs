namespace _3.CompanyHierarchy.Interfaces
{
    using Models;
    public interface IEmployee : IPerson
    {
        double Salary { get; set; }
        Department Department { get; set; }
    }
}
