module BaseType

open System

type BaseType() = 
    member _.Id = Guid.NewGuid