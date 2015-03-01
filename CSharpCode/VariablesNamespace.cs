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
using System.Diagnostics;

namespace VariablesNamespace
{
    class TestCode
    {
        //Optional and nullable reference variables
        //C#: All reference variables can be set to null. 
        void OptionalExample()
        {
            string optString = null;
            if (optString != null)
            {
                Console.WriteLine(optString);
            }

            int? length = null;
            if (length.HasValue)
            {
                Console.WriteLine(length.Value);
            }
        }



        //Tuples
        // C#: You create a tuple by instantiating a Tuple object. You access the type values using Item1, Item2, etc.
        Tuple<int, double> Summary(Box box)
        {
            return new Tuple<int, double>(box.Area(),
                box.Diagonal());
        }

        void TupleExample()
        {
            var box = new Box(0, 0, 1, 1);
            var summaryTuple = Summary(box);
            var description = "Area is " + summaryTuple.Item1
                + " and diagonal is " + summaryTuple.Item2 + ".";
        }

        //Strings and characters
        //C#: String is an alias for System.String, a class with properties, methods, and indexing. Strings can be concatenated with String.Format or the + operator.
        void StringExample()
        {
            var hello = "hello";
            var world = "world";
            var helloWorld = hello + ", " + world;
            var sayHello = string.Format("%s, %s", hello, world);
            var capitalized = helloWorld.ToUpper();
            var numberOfChars = sayHello.Length;
            var charN = sayHello[7];
            var startsWithHello = sayHello.StartsWith("hello");
        }
    }


    class Box
    {
        public Box(int a, int b, int c, int d) { ; }
        public int Area() { return 1; }
        public double Diagonal() { return 1.0; }
    }
}