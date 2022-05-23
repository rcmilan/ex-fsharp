module BaseType

open System

[<AbstractClass>]
type public BaseType() = 

    abstract Id : Guid with get