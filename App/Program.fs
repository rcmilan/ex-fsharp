open Ack
open FunctionOperators
open HelloModule
open Parametrization
open IOModule

[<EntryPoint>]
let main argv =
    
    IOHelper.Display("Usando F#")
    IOHelper.Display("Opções:\n")
    IOHelper.Display("1: Hello World")
    IOHelper.Display("2: Função Ackermann")
    IOHelper.Display("3: Encadeando funções")
    IOHelper.Display("4: Parametrização")

    let opt = IOHelper.GetInput<int> "Selecione uma opção: "

    match opt with
    | 1 -> 
        let name = IOHelper.GetInput<string> "Input: "
        SayHelloCase(name, true)

    | 2 ->
        let m = IOHelper.GetInput<int>("Digite o valor de M")
        let n = IOHelper.GetInput<int>("Digite o valor de N")
        let res = Ack m n

        IOHelper.Display $"Resultado: {res}"

    | 3 ->
        FunctionOpers.FuncPipe2

    | 4 ->
        let s = Sum 100
        let p = Product 5

        let res = s + p

        printf "%d" res
    
    | _ ->
        IOHelper.Display "Opção inválida"

    0