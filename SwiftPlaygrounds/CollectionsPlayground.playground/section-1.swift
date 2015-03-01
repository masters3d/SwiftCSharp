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

func area(b: Box) -> Int {
    return 1
}

//Lists and arrays
//Swift: You can create lists using the array data type. Use the append function to add more elements to an existing array.
var boxes = [Box]() // the empty array
boxes = [
    Box(top: 0, left: 0, bottom: 2, right: 2),
    Box(top: 0, left: 0, bottom: 1, right: 1),
    Box(top: 0, left: 0, bottom: 3, right: 4) ]
boxes.append(Box(top: 0, left: 0, bottom: 5, right: 12))



//Dictionary
//Swift: The dictionary is a built-in language type.
var emptyBoxDictionary = [Int : Box]()
var boxDictionary : [Int : Box] = [
    1 : Box(top: 0, left: 0, bottom: 2, right: 2),
    2 : Box(top: 0, left: 0, bottom: 1, right: 1),
    3 : Box(top: 0, left: 0, bottom: 3, right: 4),
    4 : Box(top: 0, left: 0, bottom: 5, right: 12)]
// add a new Box to the dictionary
boxDictionary[10] =
    Box(top: 0, left: 0, bottom: 10, right: 10)
var summary = "There are \(boxDictionary.count) boxes in the dictionary."

// direct indexing into the dictionary
var box3 = boxDictionary[3]
var asum = area(box3!)
var boxStats =
"The area of the box is \(area(boxDictionary[3]!))."




//Library Collections
//Swift: You can use additional collection types from the Foundation classes.
// The NSSet collection is initialized with a set of objects.
// You cannot add more objects after initialization.
var strings = ["one", "two", "three"]
var set : NSSet = NSSet(array: strings)
for str in set {
    println(str)
}





//Using Generics
//Swift: You can create typed-collections using generics.
class Sink<T> {
    private var list : [T] = []
    func Push(item : T) {
        list.append(item)
        
    }
    
} 

var sink = Sink<Int>() 
sink.Push(5) 
sink.Push(10) 


