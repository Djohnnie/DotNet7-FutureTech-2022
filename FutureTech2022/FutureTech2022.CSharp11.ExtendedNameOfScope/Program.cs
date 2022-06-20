// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




[Test(ParameterName = nameof(value))]
void Method(int value)
{
    Console.WriteLine(value);
}




[AttributeUsage(AttributeTargets.Method)]
class TestAttribute : Attribute
{
    public string ParameterName { get; set; }
}