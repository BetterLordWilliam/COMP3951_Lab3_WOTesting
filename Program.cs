using System.Numerics;
using System.Runtime.CompilerServices;

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
            Vector3S v3_1 = new(10, 15, 20);        // pointers work with value types
            Vector3C v3_2 = new(10, 20, 15);        // pointers are not allowed with reference types
            UnsafeClass1 usc1 = new(v3_1, v3_2);

            //unsafe
            //{
            //    fixed (Vector3* v3pf = &v3) // fixed keyword is used to pin a pointer to a managed object
            //    {
            //        usc1 = new UnsafeClass1(*v3pf);
            //    }
            //}

            Console.WriteLine($"Value of the vector (struct) = {v3_1}");
            Console.WriteLine($"Value of the vector (class) = {v3_2}");

            // Thread.Sleep(1000);

            Console.WriteLine("Use the pointers in the unsafe class to get the vector (struct/class).");
            unsafe
            {
                Console.WriteLine($"Value of the vector (struct) = {*(usc1.MyVector3S)}");  // Output?
                Console.WriteLine($"Value of the vector (class) = {*(usc1.MyVector3C)}");   // Output?
            }
        }
    }
}