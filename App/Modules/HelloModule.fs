module HelloModule

let SayHello name = printfn $"Hello {name}!"

let SayHelloCase name upperCase = 
    if upperCase = true then
        let upper = $"{name}!".ToUpper()
        SayHello upper
    else
        SayHello $"{name}!"

    