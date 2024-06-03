using InjectionDependency.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InjectionDependency.Controllers
{
    public class SalaryController : Controller
    {
        private ISalaryCalculator _salaryCalculator;

        public SalaryController(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Api/{Controller}/{yearlyAmount}")]
        public double Salary(Double yearlyAmount)
        {
            double quarterSalary = _salaryCalculator.CalculateSalary(yearlyAmount);
            return quarterSalary;
        }
    }
}
