open HelloModule
open InputModule

Display("Usando F#")
Display("Selecione uma opção: ")
Display("1: Hello World")

match GetInput("") with
| "1" -> 
    let name = GetInput("Input: ")
    SayHelloCase name true
| _ ->
    Display("Opção inválida")