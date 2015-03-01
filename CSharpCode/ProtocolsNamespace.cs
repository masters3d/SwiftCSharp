
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

namespace ProtocolsNamespace
{


    //Protocols
    //C#: A protocol is used to define a set of related functions that another type can implement.
    interface PrintSelf
    {
        string PrintString();
    }

    struct Box : PrintSelf
    {
        public int Top;
        public int Left;
        public int Height;
        public Box(int a, int b, int c, int d)
        {
            Top = a;
            Left = b;
            Height = c;
        }
        public string PrintString()
        {
            return string.Format("The box is at (%d, %d), "
            + "with height %d.",
            this.Top, this.Left, this.Height);
        }
    }
    class TestCode
    {
        void ProtocolExample()
        {
            var box = new Box(0, 0, 1, 1);
            var description = box.PrintString();
        }
    }


}