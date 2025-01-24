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
            Vector3S v3 = new(10, 15, 20);

            //unsafe
            //{
            //    fixed (Vector3* v3pf = &v3) // fixed keyword is used to pin a pointer to a managed object
            //    {
            //        usc1 = new UnsafeClass1(*v3pf);
            //    }
            //}


            // Can write unsafe blocks too btw, just means code in the scope of the block is unsafe context
            unsafe
            {
                Vector3S* v3p = &v3;
                Thread.Sleep(10);
                UnsafeClass1 usc1 = new(v3p);
                Console.WriteLine($"Value of the vector = " + *(usc1.MyVector3));
            }
        }
    }
}