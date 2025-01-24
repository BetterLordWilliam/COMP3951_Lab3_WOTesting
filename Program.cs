using System.Numerics;

namespace UnsafeTesting
{
        // int willint;
        // unsafe
        // {
        //     int* iptr = &willint;
        //     *iptr = 10;
        // }
        // Console.WriteLine(willint);
        
        // UnsafeClass us1 = new UnsafeClass(1,2);
        // us1.ShowMyStuff();

public static class Program
{
    /// <summary>
    /// Program entry.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        Vector3 v3 = new (10,15,20);
        UnsafeClass1 usc1 = new (v3);

        Thread.Sleep(10);

        // Can write unsafe blocks too btw, just means code in the scope of the block is unsafe context
        unsafe
        {
            // Somehow, somewhere else, the value was destroyed or moved.
            Console.WriteLine($"Value of the vector = " + *(usc1.MyVector3));
        }
    }
}
}