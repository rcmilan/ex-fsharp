﻿module Ack

let Ack M N =
    let rec acker (m, n, k) = 
        printf "M: %A, N %A\n" m n

        match m, n with
        | 0, n -> k(n + 1)
        | m, 0 -> acker((m - 1, 1, k))
        | m, n -> acker(m, (n - 1), (fun x -> acker((m - 1, x, k))))
    acker(M, N, (fun x -> x))