using System.Runtime.CompilerServices;

namespace UnsafeTesting
{

    /// <summary>
    /// Vector3: represents a 3D Vector.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    struct Vector3S(int x, int y, int z)
    {
        int x = x, y = y, z = z;

        public override string ToString()
        {
            return $"{x}, {y}, {z}";
        }
    }

    class Vector3C(int x, int y, int z)
    {
        int x = x, y = y, z = z;
        public override string ToString()
        {
            return $"{x}, {y}, {z}";
        }
    }

    /// <summary>
    /// Another unsafe class!
    /// </summary>
    unsafe class UnsafeClass1
    {
        public Vector3S* MyVector3 { get; }

        public UnsafeClass1(Vector3S* aVector3)
        {
            MyVector3 = aVector3;
        }
    }
}