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

//Functions
//Swift: Generic types and functions let you defer types until runtime.
// selects n items at random from an array, with replacement
func sample<T>(list : [T], n : Int) -> [T] {
    var result = [T]()
    for i in 1...n {
        var rand = Int(arc4random_uniform(UInt32(list.count)))
        result.append(list[rand])
    }
    
    return result
}

var numbers = [1, 2, 3, 4, 5, 6, 7, 8]
var asample = sample(numbers, 3)

var strings = ["one", "two", "three", "four"]
var ssample = sample(strings, 2)



