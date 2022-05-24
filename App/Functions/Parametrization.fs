module Parametrization

let private Execute fn n =
    [1..n] |> fn

let Product n =
    let initialValue = 1
    let action productSoFar x = productSoFar * x 

    Execute (List.fold action initialValue) n

let Sum n =
    let initialValue = 0
    let action sumSoFar y = sumSoFar + y

    Execute (List.fold action initialValue) n