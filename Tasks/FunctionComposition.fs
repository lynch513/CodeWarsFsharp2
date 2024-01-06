module FunctionalComposition

open Xunit

let rec compose (n: int) (f: 'a -> 'a) (x: 'a) =
    match n with
    | 0 -> x
    | _ -> compose (n - 1) f (f x)

[<Fact>]
let Tests () =
    Assert.Equal (14, compose 3 ((fun x y -> x + y) 3) 5)
    Assert.Equal (80., compose 5 ((fun x y -> x * y) 2.) 2.5)
