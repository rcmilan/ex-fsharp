module Person

open BaseType

type public Person(name : string) =
    inherit BaseType()

    override _.Id = System.Guid.NewGuid()

    member _.Name = name
