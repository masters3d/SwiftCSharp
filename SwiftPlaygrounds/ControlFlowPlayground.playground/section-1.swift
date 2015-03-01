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

class Box{
    
    init(top : Int, left: Int, bottom: Int, right: Int) {
    }
    
    func area() -> Int {
        return 1
    }
}


func area(b: Box) -> Int {
    return 1
}

enum SpecialBox {
    case Rectangle
    case Square
    case GoldenRatio

    static func GetSpecialType(b : Box) -> SpecialBox {
        return SpecialBox.Rectangle
    }

}


//For statement
//Swift: Swift supports C-style for loops, loops that iterate over collections, and loops that return (index, value) pairs.
var squares = [Box]()
for var size : Int = 1; size < 6; size++ {
    squares.append(
        Box(top: 0, left: 0, bottom: size, right: size))
}

for box in squares {
    println(area(box))
}

for (index, value) in enumerate(squares) {
    println("Area of box \(index) is \(area(value)).")
}


//If statement
//Swift: The test condition must return a Boolean value and the execution statements must be enclosed in braces.
var strings = ["one", "two", "three", "four"]
if (strings[0] == "one") {
    println("First word is 'one'.");
}


//Switch statement
//Swift: Cases do not fall through unless you use the fallthrough
//keyword. Therefore, a break statement is not required. A default case is usually required. Swift supports ranges in cases.
var aSquare = Box(top: 0, left: 0, bottom: 4, right: 4)
var label = ""
switch SpecialBox.GetSpecialType(aSquare) {
case .Square : label = "Square"
case .Rectangle : label = "Rectangle"
case .GoldenRatio : label = "Golden Ratio"
default : label = "Error"
}

var size = ""
switch aSquare.area() {
case 0...9 : size = "small"
case 10...64 : size = "medium"
default : size = "large"
}




//Exceptions
//Swift: Swift does not provide a way to catch exceptions. Instead, you should program so as to avoid exceptions.
var length = 4
assert(length > 0, "Length cannot be 0.")


