module HighScores

let scores (values: int list): int list = values

let latest (values: int list): int =
    if values.IsEmpty
        then 0
    else
        values.Item (values.Length - 1)

let personalTopThree (values: int list): int list =
    let sortedValues = List.sortDescending values
    if sortedValues.Length < 3
        then sortedValues
    else
        List.take 3 sortedValues
        
let personalBest (values: int list): int =
    if values.IsEmpty
        then 0
    else
        personalTopThree values
        |> List.max