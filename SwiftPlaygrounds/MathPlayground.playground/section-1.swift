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
    var width : Int = 1
    init(top: Int, left: Int, bottom: Int, right: Int) {
    }
    
    func area() -> Int {
        return 1
    }
}

var box0 = Box(top: 1, left: 1, bottom: 1, right: 1)
var box1 = Box(top: 1, left: 1, bottom: 1, right: 1)
var box2 = Box(top: 1, left: 1, bottom: 1, right: 1)
var box = Box(top: 1, left: 1, bottom: 1, right: 1)

//Math functions
//Swift: The math functions are global functions.
// min and max support n values
var smallest = min(box0.area(), box1.area(), box2.area())
var largest = max(box0.area(), box1.area(), box2.area())



// power
func diagonal(b : Box) -> Double {
    return sqrt(pow(Double(b.height), 2.0)
        + pow(Double(b.width), 2.0))
}



// trigonometric functions
var cos0 = cos(0.0)
var sin0 = sin(0.0)
var cosPi = cos(M_PI)




//Random numbers

//Swift: Use the arc4random_uniform function to generate uniformly distributed integers.
//generate 12 integers between 0 and 5
var rns = [UInt32]()
for i in 0...11 {
    rns.append(arc4random_uniform(5))
} 


