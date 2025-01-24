namespace UnsafeTesting
{
/// <summary>
/// UnsafeClass, `unsafe` context for all textual components of the class.
/// </summary>
unsafe class UnsafeClass
{
    int* iptr1, iptr2;

    public UnsafeClass(int i, int j)
    {
        // Safe example of assigning pointers
        // i and j are values, whose memory is NOT managed by the GC
        // This is known as fixed
        // There are references, who are managed by the GC, who are known as moveable
        // Cannot do this with moveables, unless...

        iptr1 = &i;     // Now a pointer to `i` address, which is to say stores i's address
        iptr2 = &j;     // Now a pointer to `j` address, which is to say stores j's address
    }

    /// <summary>
    /// Prints contents of pointer members and addresses the pointers store.
    /// </summary>
    public void ShowMyStuff()
    {
        Console.WriteLine($"Values\npointer1: {*iptr1}\npointer2: {*iptr2}\n-------\n"
                        + $"Address\npointer1: {(int)iptr1:X}\npointer2: {(int)iptr2:X}");
    }
}
}