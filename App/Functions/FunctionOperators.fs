module FunctionOperators

let private DoubleN n = 
    printf "dobrou %d\n" n
    n + n

let private Add10 n =
    printf "adicionou 10\n"
    n + 10
    
let private Sub10 n =
    printf "subtraiu 10\n"
    n - 10

type FunctionOps() = 
    static member FunctionComposition = 
        let Add20 = Sub10 << Add10 >> DoubleN // Ordem: Add, Sub, Double
        let Sub20 = DoubleN >> Sub10 << Add10 // Ordem: Add, Double, Sub

        let a = Add20 10
        let b = Sub20 100

        printf "a: %d b: %d" a b
    
    static member FuncOper =
        let nums = [1;2;3;4;5;6;7;8;9;10]

        nums
        |> List.map DoubleN
        |> List.iter (fun n -> printf "%d!!\n" n)
