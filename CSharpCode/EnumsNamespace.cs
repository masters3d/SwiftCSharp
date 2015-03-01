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

namespace EnumsNamespace
{

    class TestCode
    {

        SpecialBox GetSpecialType(Box box)
        {
            var width = Math.Abs(box.Top - box.Bottom);
            var length = Math.Abs(box.Left - box.Right);
            if (length == width)
                return SpecialBox.Square;
            else if (((double)length / (double)width == 1.6)
                || ((double)width / (double)length == 1.6))
                return SpecialBox.GoldenRatio;
            else
                return SpecialBox.Rectangle;
        }

        void EnumsExample()
        {
            var boxType = GetSpecialType(new Box(0, 0, 2, 2));
            var isSquare = (boxType == SpecialBox.Square);
            var goldenName = Enum.GetName(typeof(SpecialBox), 1);
        }
    }


    //Enumerations
    //C#: All enumerations are instances of System.Enum class that provides several helper methods for enumerations.
    enum SpecialBox
    {
        Rectangle,
        Square,
        GoldenRatio
    }

    class Box
    {
        public Box(int a, int b, int c, int d) { ; }
        public int Top, Bottom, Left, Right;
    }
}

