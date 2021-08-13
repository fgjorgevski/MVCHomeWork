using HomeWork2.Models.Employee.Enum;

namespace HomeWork2.Models.Emoloyee
{
    public class EmployeeDetailsViewModel
    {
        public string FullEmployeeName{ get; set; }
        public PositionEnum Position{ get; set; }
        public int DateOfHire{ get; set; }
        public string DivisionName{ get; set; }
        public double Salary { get; set; }
    }
}