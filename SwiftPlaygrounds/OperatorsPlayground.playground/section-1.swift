//*******************************************************
//
//    Copyright (c) Microsoft. All rights reserved.
//    This code is licensed under the Microsoft Public License.
//    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
//    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
//    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
//    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*******************************************************


import UIKit


class Box {
    var top : Int = 1
    var bottom : Int = 1
    var left : Int = 1
    var right : Int = 1
    init(top: Int, left: Int, bottom: Int, right: Int) {
    }
}


//Operator overloading
//Swift: In this example, adding two boxes returns a box that contains both boxes.
func + (r1: Box, r2: Box) -> Box {
    return (Box(
        top: min(r1.top, r2.top),
        left: min(r1.left, r2.left),
        bottom: max(r1.bottom, r2.bottom),
        right: max(r1.right, r2.right)))
    
}

var boxSum = Box(top: 0, left: 0, bottom: 1, right: 1)
    + Box(top: 1, left: 1, bottom: 3, right: 3)




//Equality and assignment
//Swift: The assignment operator does not return a value, therefore you canít use it as a conditional expression and you can't do chain assignments.
var a = 6
var b = a
if (b == 6) {
    a = 2
}

//Range Operator
//Swift: Use the range operator to create a range of values.
for i in 1...5 {
    println(i)
}

//Overflow
//Swift: By default, underflow and overflow produce an error at runtime. You can use the overflow operators to suppress errors, but the resulting calculation might not be what you expect.
// This code does not produce an error, but the
// resulting value is not the expected value.
var largeInt : Int = Int.max
var tooLarge : Int = largeInt &+ 1 

