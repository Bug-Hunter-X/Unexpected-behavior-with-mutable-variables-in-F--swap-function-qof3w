let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20, not 20 10 as you might expect.