module unionCase

type RecordA = { a:int }
type RecordB = { b:string; c:bool }
type RecordC = { a:int; b:string; c:bool }

type MyUnion =
    | RecordA of int
    | RecordB of string * bool
    | RecordC of int * string * bool

let x : MyUnion = RecordA(1)
let y : MyUnion = RecordB("aaaa", true)
let z : MyUnion = RecordC(2, "bbb", true)

let unionList = [| x; y; z |]

for a in unionList do
    match a with
    | RecordA(a1) -> printfn "%d" a1
    | RecordB(b1, b2) -> printfn "%s" b1
    | RecordC(c1, c2, c3) -> printfn "%d %s %b" c1 c2 c3