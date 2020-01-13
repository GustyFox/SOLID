namespace SolidExamples.LiskovSubstitution.After
{
    public interface IEmployee
    {
        int Id { get; set; }

        string GetEmployeeDetails(int employeeId);        
    }

    public interface IProject
    {
        string GetProjectsDetails(int employeeId);
    }
}