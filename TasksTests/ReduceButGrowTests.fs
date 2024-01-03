module ReduceButGrowTests

open Xunit
open ReduceButGrow

[<Fact>]
let Tests () =
    Assert.Equal(5, Grow [| 5 |])
    Assert.Equal(30, Grow [| 5; 6 |])
    Assert.Equal(120, Grow [| 4; 5; 6 |])
