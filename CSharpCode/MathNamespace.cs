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

namespace MathNamespace
{

    class TestCode
    {
        Box box = new Box(1, 1, 1, 1);
        Box box1 = new Box(1, 1, 1, 1);
        Box box2 = new Box(1, 1, 1, 1);

        //Math functions
        //C#: Math functions are provided in the System namespace.
        // min and max support 2 values for comparison
        void MathExample()
        {
            var smallest = Math.Min(box1.Area(), box2.Area());
            var largest = Math.Max(box1.Area(), box2.Area());

            // pow
            var diagonal = Math.Sqrt(
                Math.Pow((box.Top - box.Bottom), 2)
                + Math.Pow((box.Left - box.Right), 2));

            // trigonometric functions
            var cos0 = Math.Cos(0.0);
            var sin0 = Math.Sin(0.0);
            var cosPi = Math.Cos(Math.PI);
        }

        //Random numbers
        //C#: Use the Random.Next method to generate uniformly distribted integers.
        //generate 12 integers between 0 and 5
        void RandomExample()
        {
            var rns = new List<int>();
            var random = new System.Random();
            for (int i = 0; i < 12; i++)
            {
                rns.Add(random.Next(6));
            }

        }
    }

    public class Box
    {
        public Box(int a, int b, int c, int d) { ; }
        public int Top, Bottom, Left, Right;
        public int Area() { return 1; }
    }
}