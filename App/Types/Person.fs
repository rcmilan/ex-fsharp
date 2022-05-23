module Person

open BaseType

type Person(name : string) =
    inherit BaseType()
    member _.Name = name
