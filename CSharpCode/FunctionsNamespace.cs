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

namespace FunctionsNamespace
{

    class TestCode
    {
        //Functions
        //C#: Methods are always declared inside a class or struct.
        int area(Box box)
        {
            return Math.Abs((box.Top - box.Bottom)
                * (box.Left - box.Right));
        }

        //Overloading functions
        //C#: Methods can be overloaded inside a class or struct.
        string Speak()
        {
            return "woof";
        }
        string Speak(string add)
        {
            return Speak() + ", " + add;
        }
        void OverloadingExample()
        {
            Speak();
            Speak("friend");
        }

        //Reference parameters
        //C#: To change a value in a function, mark the parameter as ref and use & on the parameter in the function call.
        bool CanAdd(int a, int b, ref int sum)
        {
            sum = a + b;
            return true;
        }

        void ReferenceParametersExample()
        {
            var sum = 0;
            var success = CanAdd(3, 4, ref sum);
        }


        //Closures
        //C#: An anonymous method in C# is called a lambda.
        void ClosuresExample()
        {
            Box[] boxes = {
                new Box(0, 0, 1, 1),
                new Box(0, 0, 3, 4) };
            // sort smallest to largest
            Array.Sort(boxes, (b1, b2) => b1.Area() - b2.Area());
        }
        //Functional programming
        //C#: In C#, you create delegates that define function signatures.
        Box TallestBox(Box box1, Box box2)
        {
            return box1.Height > box2.Height ? box1 : box2;
        }
        delegate Box CompareBoxes(Box box1, Box box2);

        void FunctionalExample()
        {
            var box1 = new Box(0, 0, 1, 1);
            var box2 = new Box(0, 0, 2, 2);
            CompareBoxes compareBoxes = TallestBox;
            var tallestBox = compareBoxes(box1, box2);
        }

    }

    class Box
    {
        public Box(int a, int b, int c, int d) { ;}
        public int Top, Bottom, Left, Right, Height;
        public int Area() { return 1; }
    }
}