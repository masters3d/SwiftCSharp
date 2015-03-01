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

namespace ClassesNamespace
{


    // Classes and inheritance
    //C#: Classes support methods, properties, constructors, events, and inheritance.
    class Pet
    {
        protected string name = "";
        public Pet()
        {
        }
        public Pet(string name)
        {
            this.name = name;
        }
        public virtual string Speak()
        {
            return "";
        }
    }

    class Dog : Pet
    {
        public Dog(string name)
        {
            this.name = name;
        }
        public override string Speak()
        {
            return "woof";
        }
    }

    class TestCode
    {
        void ClassExample()
        {
            var spot = new Dog("Spot");
            spot.Speak();
        }

        //Type casting
        //C#: C# supports type casting and uses is for type checking. 
        void TypeCastingExample()
        {
            object something;
            var random = new System.Random();
            var rand = random.Next(10);
            if (rand > 5)
            {
                something = 5;
            }
            else
            {
                something = "hello";
            }
            if (something is string)
            {
                // do something
            }
            var astring = (string)something;
            var anumber = (int)something;


        }




    }
    //Extension methods
    //C#: You can add new methods to existing classes.
    public static class BoxExtensions
    {
        public static double Area(this Box box)
        {
            return Math.Abs((box.Top - box.Bottom) *
            (box.Left - box.Right));
        }
    }

    public class Box
    {
        public Box(int a, int b, int c, int d) { ;}
        public int Top, Bottom, Left, Right;
    }


}