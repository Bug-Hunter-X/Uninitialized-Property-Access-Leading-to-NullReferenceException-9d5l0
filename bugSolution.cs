public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property to a default value

    public void MyMethod()
    {
        int value = MyProperty * 2;
    }

    public ExampleClass() { MyProperty = 0; }
} 