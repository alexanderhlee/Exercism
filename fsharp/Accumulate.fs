module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list =
    let rec accumulateImp func acc = function
        | [] -> acc
        | head :: tail -> accumulateImp func (func head :: acc) tail
    accumulateImp func [] input |> List.rev