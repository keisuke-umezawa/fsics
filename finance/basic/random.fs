module fsics.finance.basic.random

open MathNet.Numerics.Random
open MathNet.Numerics.Distributions

let mt = new MersenneTwister(100)

let standardNormal = Normal.WithMeanVariance(0.0, 1.0, mt)
