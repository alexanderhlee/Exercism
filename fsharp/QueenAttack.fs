module QueenAttack

let create (x:int, y:int) =
    (x < 8 && x >= 0) &&
    (y < 8 && y >= 0)

let canAttack (queen1: int * int) (queen2: int * int) =
    let sameRow = fst queen1 = fst queen2
    let sameCol = snd queen1 = snd queen2
    let sameDiag =
        fst queen1 + snd queen1 = fst queen2 + snd queen2 ||
        fst queen1 - snd queen1 = fst queen2 - snd queen2
        
    sameRow || sameCol || sameDiag