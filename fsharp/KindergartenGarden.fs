module KindergartenGarden

type Plant = Grass | Clover | Radishes | Violets | Dead

let studentPlaces = "AABBCCDDEEFFGGHHIIJJKKLL"

let matchPlant = function
    | 'G' -> Plant.Grass
    | 'C' -> Plant.Clover
    | 'R' -> Plant.Radishes
    | 'V' -> Plant.Violets
    | _ -> Plant.Dead
    
let seedFinder (seeds: string) (cup: int) =
    seeds.[cup..cup + 1]

let plants (diagram: string) (student: string) =
    let studentCup = studentPlaces.IndexOf(student.[0..0])
    let seeds = diagram.Split[|'\n'|]
    let studentSeeds = seedFinder seeds.[0] studentCup +
                       seedFinder seeds.[1] studentCup
    studentSeeds |> Seq.toList |> List.map matchPlant
