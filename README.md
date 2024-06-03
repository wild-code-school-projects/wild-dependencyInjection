# wild-dependencyInjection
Use of Dependency injection with ASP.NET services.

# Objective

## Challenge

inject a `QuarterlySalaryCalculator` class as `ISalaryCalculator` using ASP.Net. The `QuarterlySalaryCalculator` class should convert an annual salary into a quarterly salary.

## Validation Criteria

- The files `Controllers/SalaryController.cs`, `Services/MonthlySalaryCalculator.cs`, `Services/ISalaryCalculator.cs`, and `Program.cs` remain unchanged in the solution.
- A file `Services/QuarterlySalaryCalculator.cs` defines a class implementing the `ISalaryCalculator` interface.
- The implementation of the `CalculateSalary` method in the `QuarterlySalaryCalculator` class converts an annual salary into a quarterly salary.
- In the `Program.cs` file, a call to the `AddScoped` method injects `QuarterlySalaryCalculator` as `ISalaryCalculator`.
- The route `Api/Salary/{annualAmount}` returns a quarterly salary.

![image](https://image.noelshack.com/fichiers/2024/23/1/1717401933-screenshot-2024-06-03-100009.png)
