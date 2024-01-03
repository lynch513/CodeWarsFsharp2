module FunctionalCompositionTests

open Xunit
open FunctionalComposition

[<Fact>]
let Tests () =
    Assert.Equal (14, compose 3 ((fun x y -> x + y) 3) 5)
    Assert.Equal (80., compose 5 ((fun x y -> x * y) 2.) 2.5)
