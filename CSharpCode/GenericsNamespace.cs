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

namespace GenericsNamespace
{

    class TestCode
    {
        //Functions
        //C#: Generic types and functions let you defer types until runtime.
        // selects n items at random from an array, with replacement 
        List<T> Sample<T>(T[] list, int n)
        {
            var result = new List<T>();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int r = random.Next(list.Length);
                result.Add(list[r]);
            }
            return result;
        }

        void GenericsExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var asample = Sample(numbers, 3);

            string[] strings = { "one", "two", "three", "four" };
            var ssample = Sample(strings, 2);
        }
    }

}