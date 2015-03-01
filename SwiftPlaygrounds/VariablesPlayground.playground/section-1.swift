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
    
    func area() -> Int {
        return 1
    }
    
    func diagonal() -> Double {
        return 1
    }
}


//Tuples
//Swift: You create a tuple using Swiftís tuple syntax. You access the tupleís values using the value names or indexing.
func summary(b : Box) -> (Int, Double) {
    return (b.area(), b.diagonal())
}

var box = Box(top: 0, left: 0, bottom: 1, right: 1)
var (area, diagonal) = summary(box)
var stats = (area, diagonal)
var description =
"Area is \(area) and diagonal is \(diagonal)."
var description2 =
"Area is \(stats.0) and diagonal is \(stats.1)."




//Strings and characters
//Swift: String is a value type with properties and methods that also provides all the functionality of the NSString type. Strings can be //concatenated with string interpolation or the + operator.
var hello = "hello"
var world = "world"
var helloWorld = hello + ", " + world
var sayHello = "\(hello), \(world)"
var capitalized = helloWorld.uppercaseString
var numberOfChars = countElements(sayHello)
var seventhChar = sayHello[advance(sayHello.startIndex, 7)]
var startsWithHello = sayHello.hasPrefix("hello")



//Optional and nullable reference variables
//Swift: Only optional reference variables can be set to nil.
//var optBox : Box? = Box(top: 1, left: 1, bottom: 1, right: 1)
var optBox : Box? = nil
if let aBox = optBox {
    println(aBox.top)
}
if optBox!.top > 4 {
    println("Box is not at the origin.")
}


