module SpaceAge

type Planet = { OrbitalPeriod:float }
let Mercury = { OrbitalPeriod=0.2408467 }
let Venus = { OrbitalPeriod=0.61519726 }
let Earth = { OrbitalPeriod=1.0 }
let Mars = { OrbitalPeriod=1.8808158 }
let Jupiter = { OrbitalPeriod=11.862615 }
let Saturn = { OrbitalPeriod=29.447498 }
let Uranus = { OrbitalPeriod=84.016846 }
let Neptune = { OrbitalPeriod=164.79132 }
// Sorry, Pluto!
let EarthYearSeconds = 31557600.0

let age (planet: Planet) (seconds: int64): float =
    ( (float)seconds / EarthYearSeconds ) / planet.OrbitalPeriod