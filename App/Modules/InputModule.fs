module InputModule

open System

let GetInput(inputText : string) =
    printfn $"{inputText}"
    let res = Console.ReadLine()
    res