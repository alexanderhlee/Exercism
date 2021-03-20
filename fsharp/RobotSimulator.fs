module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position =
    {direction=direction; position=position}

let moveOne robot instruction =
    let pos = robot.position
    let dir = robot.direction
    
    match instruction with
    | 'L' ->
        match dir with
        | Direction.North -> create Direction.West pos
        | Direction.West -> create Direction.South pos
        | Direction.South -> create Direction.East pos
        | _ -> create Direction.North pos
    | 'R' ->
        match dir with
        | Direction.North -> create Direction.East pos
        | Direction.East -> create Direction.South pos
        | Direction.South -> create Direction.West pos
        | _ -> create Direction.North pos
    | 'A' ->
        match dir with
        | Direction.North -> create dir (fst(pos), snd(pos) + 1)
        | Direction.East -> create dir (fst(pos) + 1, snd(pos))
        | Direction.South -> create dir (fst(pos), snd(pos) - 1)
        | _ -> create dir (fst(pos) - 1, snd(pos)) 
    | _ -> robot  
    
let move instructions robot =
    Seq.fold moveOne robot instructions
