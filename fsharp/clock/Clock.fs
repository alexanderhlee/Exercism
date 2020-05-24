module Clock

let HOURS_PER_DAY = 24
let MINUTES_PER_HOUR = 60
let minutesPerDay = HOURS_PER_DAY * MINUTES_PER_HOUR

let getTotalMinutes hours minutes =
    minutes + hours * MINUTES_PER_HOUR
    
let add minutes clock =
    let minutesCalc = (getTotalMinutes (fst clock) ((snd clock) + minutes)) % minutesPerDay
    let totalMinutes =    
        if minutesCalc < 0 then minutesCalc + minutesPerDay
        else minutesCalc
        
    let hours = (totalMinutes / MINUTES_PER_HOUR) % HOURS_PER_DAY
    let minutesPortion = totalMinutes % MINUTES_PER_HOUR
    
    (hours, minutesPortion)
    
let subtract minutes clock =
    add (-1 * minutes) clock
    
let create hours minutes =
    add (getTotalMinutes hours minutes) (0,0)

let display clock =
    sprintf "%02i:%02i" (fst clock) (snd clock)