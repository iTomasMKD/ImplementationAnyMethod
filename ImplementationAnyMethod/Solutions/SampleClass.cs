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
    public void BadSampleMethod(IEnumerable<EmployeeType>? employees)
    {
        if (employees is null || employees.Count() == 0)
        {
            return;
        }j
    }

    /// <summary>
    /// Demonstrates the preferred empty-sequence check because Any() can stop as
    /// soon as the first item is found.
    /// </summary>9
    public void GoodSampleMethod(IEnumerable<EmployeeType>? employees)
    {
        if (employees is null || !employees.Any())
        {
            return;
        }
    }
}
