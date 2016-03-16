#load "./load-project-debug.fsx"
open fsics.finance.basic
open FSharp.Charting

//random.standardNormal.Density(0.0)

let expfunc x = x, exp x
let logfunc x = x, log x


let c =Chart.Combine
    [ Chart.Line([0.1 .. 0.1 .. 10.0] |> List.map (fun x -> x, x), Name = "exp")
      Chart.Line([0.1 .. 0.1 .. 10.0] |> List.map logfunc, Name = "log") ]);;
c.ShowChart();;      
