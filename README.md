# SwiftCSharp
Comparing Swift and C#

"Swift and C# Quick Reference – Language Equivalents and Code Examples"

Reference http://download.microsoft.com/download/4/6/9/469501F4-5F6B-4E51-897C-9A216CFB30A3/SwiftCSharpPoster.pdf


| Variables   |      Swift     |          C#         |
|-------------|:--------------:|:-------------------:|
| boolean     |      Bool      |         bool        |
| constant    |       let      |        const        |
| declaration |       var      |         var         |
| float       |  Float, Double |    float, double    |
| integer     |       Int      |         int         |
| optional    |  ? (optional)  |     ? (nullable)    |
| tuple       |      tuple     |     System.Tuple    |
| string      | String (value) | string  (reference) |

| Operators         | Swift               |              C#             |
|-------------------|:-------------------:|:---------------------------:|
| arithmetic        | +, -, *, /, %       | +, -, *, /, %               |
| assignment        | =                   | =                           |
| bitwise           |<<, >>, &, \|, ~, ^, | <<, >>, <<=, >>= &, \|, ^, ~|
| overflow          | &+, &-, &*, &/, &%  |        checked unchecked    |
| overloading       | overloading         | overloading                 |
| range             | a..<b, a…b          | (no equivalent)             |
| relational        | ==, !=, >, <        | ==, !=, >, <                |

| Programs                |             Swift            |               C#              |
|-------------------------|:----------------------------:|:-----------------------------:|
| attribute               |        (no equivalent)       |           attributes          |
| memory management       | automatic reference counting | tree-based garbage collection |
| module                  |            module            |            library            |
| namespace               |        (no equivalent)       |           namespace           |
| preprocessor directives |        (no equivalent)       |    preprocessor directives    |

| Control flow     |        Swift        |        C#        |
|------------------|:-------------------:|:----------------:|
| break, continue  |   break, continue   |  break, continue |
| do-while         |       do-while      |     do-while     |
| for              |         for         |        for       |
| for-in           |        for-in       |    foreach-in    |
| if               |          if         |        if        |
| locking          |   (no equivalent)   |       lock       |
| queries          |   (no equivalent)   |       LINQ       |
| switch           | switch, fallthrough |      switch      |
| try-catch, throw |        assert       | try-catch, throw |
| using            |   (no equivalent)   |       using      |
| unsafe           |   (no equivalent)   |      unsafe      |
| while            |        while        |       while      |
| yield            |   (no equivalent)   |       yield      |

| Classes      |       Swift               |                  C#                 |
|--------------|:-------------------------:|:-----------------------------------:|
| constructor  |       init                |             constructor             |
| class        |       class               |                class                |
| delegate     |  function types           |               delegate              |
| destructor   |      deinit               |             destructor              |
| extension    |     extension             |              extension              |
| indexing     |     subscript             |               indexer               |
| inheritance  |         :                 |                  :                  |
| access       | private, internal, public | public, private, protected, interal |
| object       |  AnyObject, Any           |                object               |
| self         |       self                |                 this                |
| type casting |    is, as, as?            |          cast, dynamic, as          |
| type alias   |     typealias             |                using                |

| Types        |    Swift    |        C#       |
|--------------|:-----------:|:---------------:|
| enumerations |     enum    |       enum      |
| functions    | static func | (no equivalent) |
| protocol     |   protocol  |    interface    |
| struct       |    struct   |      struct     |

| Functions       |    Swift    |        C#       |
|-----------------|:-----------:|:---------------:|
| anonymous       |   closures  |     lambdas     |
| class method    |    static   |      static     |
| method          |     func    |      method     |
| overloaded      | overloading |   overloading   |
| override        |   override  |     override    |
| ref parameter   |   inout, &  |      ref, &     |
| parameter array |    params   | parameter array |
| return          |    return   |      return     |

| Collections    |        Swift        |         C#         |
|----------------|:-------------------:|:------------------:|
| dictionary     |      Dictionary     |   Dictionary\<S,T>  |
| initialization | object  initializer | object initializer |
| list           |        Array        |       List\<T>      |
| set            |         Set         |     HashSet\<T>     |

| Math           |  Swift |         C#         |      C# (6)     |
|----------------|:------:|:------------------:|:---------------:|
| minimum        |   min  |   System.Math.Min  |       Min       | 
| maximum        |   max  |   System.Math.Max  |       Max       |
| power          |   pow  |   System.Math.Pow  |       Pow       |
| random numbers | random | System.Random.Next |   Random.Next   |
| trigonometry   |   sin  |   System.Math.Sin  |       Sin       |

| Generics |       Swift       |         C#        |
|----------|:-----------------:|:-----------------:|
| function | generic functions | generic functions |
| type     |   generic types   |   generic types   |







