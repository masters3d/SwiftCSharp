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

//Swift: A protocol is used to define a set of related functions that another type can implement.
protocol PrintSelf {
    func ToString() -> String
}



struct Box : PrintSelf {
    var top: Int = 0
    var left: Int = 0
    var height: Int = 0
    func ToString() -> String {
        return "The box is at (\(self.top), "
            + "\(self.left)), with height "
            + "\(self.height)."
    }
}



var boxPrint = Box(top: 0, left: 0, height: 2)
var desc = boxPrint.ToString() 

