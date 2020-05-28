module Bob
open System.Text.RegularExpressions

let response (input: string): string =
    let (|Empty|_|) (i: string) =
        if i.Trim().Length = 0 then Some(i) else None
        
    let (|Question|_|) (i: string) =
        if (i.TrimEnd() |> Seq.last).Equals('?') then Some(i) else None
        
    let (|AllCaps|_|) (i: string) =
        if Regex.IsMatch(i,"[a-zA-Z]") && i.ToUpper().Equals(i) then Some(i) else None
    
    match input with
        | Empty _ -> "Fine. Be that way!"
        | Question _ & AllCaps _ -> "Calm down, I know what I'm doing!"
        | Question _ -> "Sure."
        | AllCaps _ -> "Whoa, chill out!"
        | _ -> "Whatever."
        