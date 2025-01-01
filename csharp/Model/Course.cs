namespace FirstConsoleApp.Models // namespace for the that houses the class course
{
    public class Course
    {
    public string Code { get; set; } // get and set allow you to control how properties in c# are stored and accessed
    public int Unit { get; set; }
    public int Score { get; set; }
    public string Grade { get; set; }
    public int GradeUnit { get; set; }
    public int WeightPoint { get; set; }
    public string Remark { get; set; }
    }
}