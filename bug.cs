public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized can lead to unexpected behavior.
        int value = MyProperty; // If MyProperty hasn't been set, it will have a default value (0 for ints)
    }
}