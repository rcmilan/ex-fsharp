open HelloModule
open IOModule

IOHelper.Display("Usando F#")
IOHelper.Display("Selecione uma opção: ")
IOHelper.Display("1: Hello World")

match IOHelper.GetInput<int>("") with
| 1 -> 
    let name = IOHelper.GetInput<string>("Input: ")
    SayHelloCase name true
| _ ->
    IOHelper.Display("Opção inválida")