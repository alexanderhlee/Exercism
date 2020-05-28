module BeerSong

let recite (startBottles: int) (takeDown: int) =
    let lastTake = startBottles - (takeDown - 1)

    let verse (b: int) =
        let bName n =
            if n <> 1 then "bottles" else "bottle"

        [
            if b >= 2 then
                yield sprintf "%i bottles of beer on the wall, %i bottles of beer." b b
                yield sprintf "Take one down and pass it around, %i %s of beer on the wall." (b - 1) (bName (b - 1))
                
            elif b = 1 then
                yield "1 bottle of beer on the wall, 1 bottle of beer."
                yield "Take it down and pass it around, no more bottles of beer on the wall."

            else
                yield "No more bottles of beer on the wall, no more bottles of beer."
                yield "Go to the store and buy some more, 99 bottles of beer on the wall."
                
            if b > lastTake then yield ""
        ]

    [ for x in 0 .. takeDown - 1 do yield startBottles - x ]
    |> List.collect verse
    