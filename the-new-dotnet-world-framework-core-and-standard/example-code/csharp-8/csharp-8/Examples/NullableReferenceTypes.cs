using System;

namespace csharp_8
{
    public static partial class Examples
    {
        public static void NullableReferenceTypes()
        {
            //NO COMPILER WARNING
            string s1 = null;
            Console.WriteLine($"Hello, {s1}!");

            //COMPILER WARNING
            #nullable enable
            string s2 = null;
            Console.WriteLine($"Hello, {s2}!");
            #nullable restore
        }
    }
}
