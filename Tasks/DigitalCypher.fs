module DigitalCypher

open System
open Xunit

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

[<Fact>]
let Tests () =
    Assert.Equal<int list>([20; 12; 18; 30; 21], encode "scout" 1939)
    Assert.Equal<int list>([14; 10; 22; 29; 6; 27; 19; 18; 6; 12; 8], encode "masterpiece" 1939)
