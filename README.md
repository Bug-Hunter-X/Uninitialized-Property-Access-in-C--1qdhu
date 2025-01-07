# Uninitialized Property Access in C#

This repository demonstrates a common issue in C#: accessing a property of a class before it has been assigned a value. While C# provides default values for uninitialized properties, relying on these defaults can lead to unexpected behavior and subtle bugs.  The example shows how to safely handle potential uninitialized property values.

## Bug
The `bug.cs` file shows a simple class with a property that might not be initialized before it is accessed.