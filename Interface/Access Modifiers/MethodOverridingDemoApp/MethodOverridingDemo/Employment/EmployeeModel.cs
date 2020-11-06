namespace MethodOverridingDemo
{
    public class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }

        public virtual decimal GetPaycheckAfterTax(int hoursWorked) 
        {
            return HourlyRate * hoursWorked;
        }
    }
}
