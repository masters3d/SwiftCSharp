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

//Swift: An enumeration is a type, and you can add functions to the type definition.
enum SpecialBox {
    case Rectangle
    case Square
    case GoldenRatio
    
    static func GetSpecialType(r : Box) -> SpecialBox {
        var width = abs(r.top - r.bottom)
        var length = abs(r.left - r.right)
        if (length == width) {
            return SpecialBox.Square }
        else if ((Double(length)/Double(width) == 1.6)
            || (Double(width)/Double(length) == 1.6)) {
                return SpecialBox.GoldenRatio }
        else {
            return SpecialBox.Rectangle}
    }
}

var isASquare = SpecialBox.GetSpecialType(
    Box(top: 0, left: 0, bottom: 2, right: 2)) 
var s = "\(isASquare == SpecialBox.Square)"

