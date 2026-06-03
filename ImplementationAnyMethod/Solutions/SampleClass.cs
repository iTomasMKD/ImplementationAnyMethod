namespace ImplementationAnyMethod.Solutions;

public enum EmployeeType
{
    Unknown = 0,
    FullTime = 1,
    Contractor = 2,
    Intern = 3
}

public sealed class SampleClass
{
    /// <summary>
    /// Demonstrates the slower empty-sequence check because Count() can enumerate
    /// the entire collection before returning a result.
    /// </summary>
    public bool HasEmployeesUsingCount(IEnumerable<EmployeeType>? employees) => employees is null ? false : employees.Count() > 0;

    /// <summary>
    /// Demonstrates the preferred empty-sequence check because Any() can stop as
    /// soon as the first item is found.
    /// </summary>
    public bool HasEmployees(IEnumerable<EmployeeType>? employees) => employees is null ? false : employees.Any();
}
