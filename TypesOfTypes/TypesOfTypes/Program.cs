using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace TypesOfTypes
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            //int ImAValueType = 12;
            //int ImAnotherValueType = ImAValueType;



            //int* pointerToValueType = &ImAValueType;
            //int* pointerToAnotherValueType = &ImAnotherValueType;

            //Console.WriteLine($"Value of the variable ImAValueType: {ImAValueType}");
            //Console.WriteLine($"Value of the variable ImAnotherValueType: {ImAnotherValueType}");
            //Console.WriteLine($"Address of the variable pointerToValueType: {(long)pointerToValueType:X}");
            //Console.WriteLine($"Address of the variable pointerToAnotherValueType: {(long)pointerToAnotherValueType:X}");


            int[] ReferenceType = new int[12];
            int ImAReferenceType = ReferenceType[1];
            int ImAnotherReferenceType = ReferenceType[1];

            int* pointerToReferenceType = &ImAReferenceType;
            int* pointerToAnotherVReferenceType = &ImAnotherReferenceType;


            Console.WriteLine($"Value of the variable ImAReferenceType: {ImAReferenceType}");
            Console.WriteLine($"Value of the variable ImAnotherReferenceType: {ImAnotherReferenceType}");
            Console.WriteLine($"Address of the variable pointerToReferenceType: {(long)pointerToReferenceType:X}");
            Console.WriteLine($"Address of the variable pointerToAnotherVReferenceType: {(long)pointerToAnotherVReferenceType:X}");
        }

    }
}
