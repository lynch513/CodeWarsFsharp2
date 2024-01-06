module DigitalCypher

open System

let char2digit (c: char) =
    c |> Char.ToLower |> int |> (fun i -> i - 96)

let getKeyNth (key: int) (index: int) =
    let keySeq = key |> string |> Seq.map (fun i -> i |> string |> int)
    let infiniteSeq = Seq.initInfinite (fun _ -> keySeq) |> Seq.concat
    Seq.item index infiniteSeq

let encode (str: string) (n: int) =
    str
    |> Seq.map char2digit
    |> Seq.mapi (fun index item -> item + getKeyNth n index)
    |> Seq.toList

let test = "scout"

printfn "Word: %s, Integer: %A" test (encode test 1939)
