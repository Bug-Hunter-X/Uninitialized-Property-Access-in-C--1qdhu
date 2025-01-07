public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Check if the property has been assigned a value
        if (MyProperty == 0) // Or use a more sophisticated check depending on the property type and its allowed values
        {
            // Assign it to a default value before using it
            MyProperty = -1;
        }

        int value = MyProperty; 
    }
}