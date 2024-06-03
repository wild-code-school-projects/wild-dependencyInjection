using InjectionDependency.Interfaces;

namespace InjectionDependency.Services;

public class MonthlySalaryCalculator : ISalaryCalculator
{
    public Double CalculateSalary(Double yearlyAmount)
    {
        return yearlyAmount / 12;
    }
}
