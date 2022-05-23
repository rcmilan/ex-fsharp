module IOModule

open System

type IOHelper() =

    static member Display(inputText : string) =
        printfn $"{inputText}"

    static member GetInput<'T>(?inputText : string) = 
        let inputText = (defaultArg inputText) ""
        
        if not (String.IsNullOrEmpty(inputText)) then
            Console.WriteLine (inputText)

        let mutable input = Console.ReadLine()

        (Convert.ChangeType(input, typeof<'T>)) :?> 'T

    