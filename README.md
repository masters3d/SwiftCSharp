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
| attribute               |        Non user [definable attibutes][swift attributes]       |           User defined [attributes][csharp attributes]          |
| memory management       | automatic reference counting | tree-based garbage collection |
| module                  |            module            |            library            |
| namespace               |        (no equivalent)       |           namespace           |
| preprocessor directives |        [compiler directives][swift compiler directives], [diagnostic-directives][swift diagnostic-directives]      |    preprocessor [directives][csharp pre processor]    |

| Control flow     |        Swift        |        C#        |
|------------------|:-------------------:|:----------------:|
| break, continue  |   break, continue   |  break, continue |
| do-while         |       repeat-while      |     do-while     |
| for              |         for         |        for       |
| for-in           |        for-in       |    foreach-in    |
| if               |          if         |        if        |
| locking          |   (no equivalent)   |       lock       |
| queries          |   (no equivalent)   |       LINQ       |
| switch           | switch, fallthrough |      switch      |
| try-catch, throw |        assert, try-catch, throw       | try-catch, throw |
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
| access       | private, fileprivate, internal, public, open | public, private, protected, interal |
| object       |  AnyObject, Any           |                object               |
| self         |       self                |                 this                |
| type casting |    is, as, as?            |         is, cast, dynamic, as          |
| type alias   |     typealias (supports Generics)             |                using                |

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
| parameter array |    params, T...   | parameter array |
| return          |    return   |      return     |

| Collections    |        Swift        |         C#         |
|----------------|:-------------------:|:------------------:|
| dictionary     |      Dictionary     |   Dictionary\<S,T>  |
| initialization | object  initializer | object initializer |
| list           |        Array        |       List\<T>      |
| set            |         Set         |     HashSet\<T>     |

| Math           |  Swift |      C#     |
|----------------|:------:|:---------------:|
| minimum        |   min  |       Min       | 
| maximum        |   max  |       Max       |
| power          |   pow  |       Pow       |
| random numbers | [random][swift random]  |  Random.Next   |
| trigonometry   |   sin  |       Sin       |

| Generics |       Swift       |         C#        |
|----------|:-----------------:|:-----------------:|
| function | generic functions | generic functions |
| type     |   generic types   |   generic types   |


[swift attributes]: https://developer.apple.com/library/content/documentation/Swift/Conceptual/Swift_Programming_Language/Attributes.html
[csharp attributes]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/attributes/
[csharp pre processor]: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives/
[swift compiler directives]: https://developer.apple.com/library/content/documentation/Swift/Conceptual/Swift_Programming_Language/Statements.html#//apple_ref/doc/uid/TP40014097-CH33-ID538
[swift diagnostic-directives]: https://github.com/apple/swift-evolution/blob/master/proposals/0196-diagnostic-directives.md
[swift random]: https://github.com/apple/swift-evolution/blob/master/proposals/0202-random-unification.md



