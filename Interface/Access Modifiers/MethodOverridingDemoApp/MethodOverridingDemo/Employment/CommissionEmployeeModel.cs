namespace MethodOverridingDemo
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmt { get; set; }

        public override decimal GetPaycheckAfterTax(int hoursWorked)
        {
            decimal initialPay = base.GetPaycheckAfterTax(hoursWorked);
            
            return initialPay + CommissionAmt;
        }
    }
}
