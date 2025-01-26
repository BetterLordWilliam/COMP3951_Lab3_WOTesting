using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

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
            //Vector3C v3_2 = new(10, 20, 15);        // pointers are not allowed with reference types

            ////unsafe
            ////{
            ////    fixed (Vector3* v3pf = &v3) // fixed keyword is used to pin a pointer to a managed object
            ////    {
            ////        usc1 = new UnsafeClass1(*v3pf);
            ////    }
            ////}

            //UnsafeClass1 usc1 = new(v3_1, v3_2);
            //// Thread.Sleep(1000);

            //int myInt = 100;
            //int[] myInts = [10, 20, 30, 40, 50, 60];
            //// Console.WriteLine("Use the pointers in the unsafe class to get the vector (struct/class).");
            //unsafe
            //{
            //    // Need to fix array pointers in memory
            //    fixed (int* pp = &(myInts[0])) {
            //        for (int i = 0; i < myInts.Length; i++)
            //        {
            //            Console.WriteLine(*(pp + i));
            //        }
            //    }
            //    Console.WriteLine($"Value of the vector (struct) = {*(usc1.MyVector3S)}");  // Output?`
            //}
public static class Program
{
    /// <summary>
    /// Program entry.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        Vector3S v3_1 = new(10, 15, 20);        // pointers work with value types
        Vector3S v3_2 = v3_1;                   // recall that structs are value types

        Console.WriteLine(v3_1);
        Console.WriteLine(v3_2);

        // Re-assign the scalars of v3_1
        v3_1.x = 20;
        v3_1.y = 10;
        v3_2.z = 15;

        // What will the output be ?
        Console.WriteLine(v3_1);
        Console.WriteLine(v3_2);
    }
}
}