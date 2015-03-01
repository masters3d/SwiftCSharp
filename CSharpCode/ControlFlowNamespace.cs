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
using System.Collections.Generic;

namespace ControlFlowNamespace
{

    class TestCode
    {
        // For statement
        //C#: You can use C-style for loops and loops that iterate over collections.
        void ForExample()
        {
            var squares = new List<Box>();
            for (int size = 1; size < 6; size++)
            {
                squares.Add(new Box(0, 0, size, size));
            }
            foreach (var square in squares)
            {
                Console.WriteLine(area(square));
            }
        }

        int area(Box b)
        {
            return 1;
        }

        //If statement
        //C#: C# allows non-Boolean test conditions and braces are not required around the execution statements.
        void IfExample()
        {
            string[] strings = { "one", "two", "three" };
            if (strings[0] == "one")
            {
                Console.WriteLine("First word is 'one'.");
            }
        }

        //Switch statement
        //C#: Switch cases fall through by default. Therefore, you need to add a break statement to each case where you don’t want fall through. A default case is not required.
        void SwitchExample()
        {
            var aSquare = new Box(0, 0, 4, 4);
            var label = "";
            switch (GetSpecialType(aSquare))
            {
                case SpecialBox.Square:
                    label = "Square"; break;
                case SpecialBox.Rectangle:
                    label = "Rectangle"; break;
                case SpecialBox.GoldenRatio:
                    label = "Golden Ratio"; break;
                default: label = "Error"; break;
            }
        }

        enum SpecialBox
        {
            Square,
            Rectangle,
            GoldenRatio
        }

        SpecialBox GetSpecialType(Box b)
        {
            return SpecialBox.GoldenRatio;
        }

        //Exceptions
        //C#: You can use try-catch for exception-handling, but catching exceptions has a significant performance impact.
        void ExceptionExample()
        {
            float i = 2;

            try
            {
                var div = 1 / i;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero.");
            }
        }
    }

    class Box
    {
        public Box(int a, int b, int c, int d) { ;}
    }
}