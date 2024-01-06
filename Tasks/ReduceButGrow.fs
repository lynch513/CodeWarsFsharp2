module ReduceButGrow

open Xunit

let Grow = Array.reduce (*)

[<Fact>]
let Tests () =
    Assert.Equal(5, Grow [| 5 |])
    Assert.Equal(30, Grow [| 5; 6 |])
    Assert.Equal(120, Grow [| 4; 5; 6 |])
