//*********************************************************
//
//    Copyright (c) Microsoft. All rights reserved.
//    This code is licensed under the Microsoft Public License.
//    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
//    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
//    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
//    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Linq;

namespace OperatorsNamespace
{


    // Operator overloading
    // C#: Adding two boxes returns a box that contains both boxes.
    public class Box
    {
        public Box(int a, int b, int c, int d) { ; }
        public int Top, Left, Bottom, Right;

        public static Box operator +(Box box1, Box box2)
        {
            return new Box(
                (int)Math.Min(box1.Top, box2.Top),
                (int)Math.Min(box1.Left, box2.Left),
                (int)Math.Max(box1.Bottom, box2.Bottom),
                (int)Math.Max(box1.Right, box2.Right));
        }
    }

    class TestCode
    {
        void OverloadingExample()
        {
            var boxSum = new Box(0, 0, 1, 1) + new Box(1, 1, 3, 3);
        }

        //Equality and assignment
        //C#: Chain assignment is allowed and testing assignment expressions is allowed.
        void EqualityExample()
        {
            int b = 2;
            int a = b = 6;
            if ((b = 6) == 6)
                a = 2;
        }


        //Range Operator
        //C#: Use the Enumerable.Range method to generate a List of integers.
        void RangeExample()
        {
            foreach (int i in Enumerable.Range(1, 5).ToList())
            {
                Console.WriteLine(i);
            }
        }
        //Overflow
        //C#: By default, underflow and overflow do not produce an error. You can use the checked keyword so that an exception is thrown at runtime. If you are using implicit variable declarations, the runtime will create variables that can contain the underflow or overflow value.
        // This code throws an exception at runtime.
        void OverflowExample()
        {
            int largeInt = int.MaxValue;
            checked
            {
                int tooLarge = largeInt + 5;
            }
        }


    }
}