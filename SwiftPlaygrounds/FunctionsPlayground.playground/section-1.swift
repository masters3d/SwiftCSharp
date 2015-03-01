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
    var height : Int = 1
    init(top: Int, left: Int, bottom: Int, right: Int) {
    }
    
    func area() -> Int {
        return 1
    }
    
}



//Swift: Functions can be declared both as type members and in top-level code.
func area(box : Box) -> Double {
    return abs(Double((box.top - box.bottom)
        * (box.left - box.right)))
}






//Overloading functions
//Swift: Function overloading is supported wherever functions can be declared.
func speak() -> String {
    return "woof"
}

func speak(add : String) -> String {
    return speak() + ", " + add
}
speak()
speak("friend")


//Reference parameters
//Swift: To change a value in a function, mark the parameter as inout and use & on the parameter in the function call.
func canAdd(a : Int, b: Int, inout sum : Int) -> Bool {
    sum = a + b
    return true
}

var sum = 0
var success = canAdd(3, 4, &sum)



//Closures
//Swift: An anonymous function in Swift is called a closure.
var boxes = [
    Box(top: 0, left: 0, bottom: 2, right: 2),
    Box(top: 0, left: 0, bottom: 3, right: 4) ]
var smallToLarge = sorted(boxes,
    { b1, b2 in return b1.area() < b2.area()})


//Functional programming
//Swift: Functions are first-class objects in Swift.
func tallestBox(b1 : Box, b2 : Box) -> Box {
    return b1.height > b2.height ? b1 : b1
}

var box1 = Box(top: 0, left: 0, bottom: 2, right: 2)
var box2 = Box(top: 0, left: 0, bottom: 3, right: 4)
var compareBoxes : (Box, Box) -> Box = tallestBox
var tallest = compareBoxes(box1, box2)


