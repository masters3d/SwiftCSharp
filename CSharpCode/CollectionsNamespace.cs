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

namespace CollectionsNamespace
{

    class TestCode
    {
        //Lists and arrays
        //C#: You can create lists using array or List objects. The List object lets you add more elements to an existing List.
        void ListArrayExample()
        {
            var noBoxes = new Box[] { }; // the empty array
            Box[] boxes = {
    new Box(0, 0, 1, 1),
    new Box(0, 0, 2, 2),
    new Box(0, 0, 3, 4) };
            List<Box> moreBoxes = new List<Box>();
            moreBoxes.Add(new Box(0, 0, 1, 1));
            moreBoxes.Add(new Box(0, 0, 2, 2));
            moreBoxes.Add(new Box(0, 0, 3, 4));
        }

        //Dictionary
        //C#: The .NET library provides the generic Dictionary object.
        void DictionaryExample()
        {
            var emptyBoxDictionary = new Dictionary<int, Box>();
            var boxDictionary = new Dictionary<int, Box> {
    { 1, new Box(0, 0, 2, 2)} ,
    { 2, new Box(0, 0, 1, 1)} ,
    { 3, new Box(0, 0, 3, 4)} ,
    { 4, new Box(0, 0, 5, 12)}};
            // add a new box to the dictionary
            boxDictionary[10] = new Box(0, 0, 10, 10);
            var summary = "There are" + boxDictionary.Count
                + " boxes in the dictionary.";

            // direct indexing into the dictionary
            var box3 = boxDictionary[3];
            // a more robust way to select an object
            if (boxDictionary.TryGetValue(3, out box3))
            {
                var boxStats = "The area of box 3 is "
                    + area(box3) + ".";
            }
        }

        int area(Box b) { return 1; }

        //Library Collections
        //C#: You can use additional collections from the System.Collections namespace.
        // The HashSet collection can be initialized empty or with objects. 
        // You can add more objects after initialization.
        void LibraryExample()
        {
            string[] strings = { "one", "two" };
            HashSet<string> set = new HashSet<string>(strings);
            set.Add("three");
            foreach (var str in set)
            {
                Console.WriteLine(str);
            }
        }

        //Using Generics
        //C#: You can create typed-collections using generics.
        public class Sink<T>
        {
            private List<T> list = new List<T>();
            public void Push(T item)
            {
                list.Add(item);
            }
        }
        void GenericsExample()
        {
            Sink<int> sink = new Sink<int>();
            sink.Push(5);
            sink.Push(10);
        }
    }
    class Box
    {
        public Box(int a, int b, int c, int d) { ; }
    }

}