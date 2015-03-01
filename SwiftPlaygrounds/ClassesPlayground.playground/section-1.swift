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

//Classes and inheritance
//Swift: Classes support functions, properties, constructors, and inheritance.
class Pet {
    var name : String = ""
    init(name : String) {
        self.name = name
    }
    
    func speak() -> String {
        return ""
    }
}



class Dog : Pet {
    override func speak() -> String {
        return "woof"
    }
}



var spot = Dog(name: "Spot")
spot.speak()


class Box {
    var top : Int = 1
    var bottom : Int = 1
    var left : Int = 1
    var right : Int = 1
    
    init(top: Int, left: Int, bottom: Int, right: Int) {
    }
}

//Extension methods
//Swift: You can add new methods to existing classes.
extension Box {
    func area() -> Int { return abs((self.top - self.bottom) * (self.left - self.right)) }
}



//Type casting
//Swift: Use as for type casting and is for type checking. The compiler will prevent you from using is if the compiler can determined the type at compile time.

var something : Any
var rand = Int(arc4random_uniform(UInt32(10)))
if rand > 5 {
    something = "hello"
}
else {
    something = 5
}

if something is String {
    
}

//One of these will throw an error, because something is either a string or an integer.
var anumber = something as Int
var astring = something as String 


