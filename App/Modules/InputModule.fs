module InputModule

open System

let Display(inputText : string) =
    printfn $"{inputText}"

let GetInput (inputText : string) =
    Display(inputText)
    let res = Console.ReadLine()
    res
