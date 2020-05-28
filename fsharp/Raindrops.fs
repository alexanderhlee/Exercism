module Raindrops

let convert (number: int): string =
    // Create a list of tuples representing the three sounds.
    [3, "Pling"; 5, "Plang"; 7, "Plong"]
    
    // Only keep the sounds whose numbers divide evenly.
    |> List.filter (fun (divisor, _) -> number % divisor = 0)
    
    // Concatenate the resulting sounds together
    |> List.fold (fun takeSnd x -> takeSnd + snd x) ""
    
    // Output the result, or just return the number if there were no sounds.
    |> fun result ->
       match result with
       | "" -> (string) number
       | _ -> result