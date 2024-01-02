module HowGreenIsMyValleyTests

open Xunit
open HowGreenIsMyValley

[<Fact>]
let ``How Green Is My Valley Tests`` () =
    Assert.Equal<list<int>>([77], makeValley [77])
    Assert.Equal<list<int>>([], makeValley [])
    Assert.Equal<list<int>>([98; 77; 31; 24; -62; 26; 54; 93], makeValley [98; 93; 77; 54; 31; 26; 24; -62])
    Assert.Equal<list<int>>([99; 57; 50; 28; -61; 39; 54; 96], makeValley [99; 96; 57; 54; 50; 39; 28; -61])
    Assert.Equal<list<int>>([93; 64; 33; 30; 58; 83], makeValley [93; 83; 64; 58; 33; 30])
    Assert.Equal<list<int>>([86; 79; 31; -78; 33; 80], makeValley [86; 80; 79; 33; 31; -78])
    Assert.Equal<list<int>>([70; -25], makeValley [70; -25])
    Assert.Equal<list<int>>([73; 49; 32; -33; -55; 26; 33; 62], makeValley [73; 62; 49; 33; 32; 26; -33; -55])
    Assert.Equal<list<int>>([91; 32; 60], makeValley [91; 60; 32])
    Assert.Equal<list<int>>([90; 47; 27; -91; 16; 33; 78], makeValley [90; 78; 47; 33; 27; 16; -91])
