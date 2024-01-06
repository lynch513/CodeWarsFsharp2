module DigitalCypherTests

open Xunit
open DigitalCypher

[<Fact>]
let Tests () =
    Assert.Equal<int list>([20; 12; 18; 30; 21], encode "scout" 1939)
    Assert.Equal<int list>([14; 10; 22; 29; 6; 27; 19; 18; 6; 12; 8], encode "masterpiece" 1939)
