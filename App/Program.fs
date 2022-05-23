open HelloModule
open IOModule
open Ack

[<EntryPoint>]
let main argv =
    
    IOHelper.Display("Usando F#")
    IOHelper.Display("Opções:\n")
    IOHelper.Display("1: Hello World")
    IOHelper.Display("2: Função Ackermann")

    let opt = IOHelper.GetInput<int> "Selecione uma opção: "

    match opt with
    | 1 -> 
        let name = IOHelper.GetInput<string> "Input: "
        SayHelloCase name true

    | 2 ->
        let m = IOHelper.GetInput<int>("Digite o valor de M")
        let n = IOHelper.GetInput<int>("Digite o valor de N")
        let res = Ack m n

        IOHelper.Display $"Resultado: {res}"
    
    | _ ->
        IOHelper.Display "Opção inválida"

    0 // Return 0