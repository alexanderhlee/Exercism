module Pangram

let isPangram (input: string): bool =
    String.forall (fun c -> input.ToLower().Contains c) "abcdefghijklmnopqrstuvwxyz"