module IOModule

open System

type IOHelper() =

    static member Display(inputText : string) = printfn "%s" inputText

    static member GetInput<'T>(?inputText : string) = 
        let inputText = defaultArg inputText ""
        
        if (inputText <> "") then
            IOHelper.Display inputText

        let input = Console.ReadLine()

        Convert.ChangeType(input, typeof<'T>) :?> 'T

    