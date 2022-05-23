module HelloModule

let SayHello name =
    printfn "Hello %s!" name

let SayHelloCase (name : string, upperCase : bool) =
    if upperCase = true then
        let upper = $"{name}!".ToUpper()
        SayHello upper
    else
        SayHello name

    