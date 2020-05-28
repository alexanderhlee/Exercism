module Grains

let square (n: int): Result<uint64,string> =   
    if n > 64 || n <= 0 then Error "square must be between 1 and 64"
    else Ok (pown 2UL (n-1))
    
let total: Result<uint64,string> =
    Ok ([0..63] |> Seq.sumBy(fun x -> pown 2UL x))