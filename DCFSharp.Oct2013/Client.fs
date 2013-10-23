namespace DCFSharp.Oct2013

open System
open IntelliFactory.WebSharper
open IntelliFactory.WebSharper.Html
open IntelliFactory.WebSharper.Html5

[<JavaScript>]
module Client =

    let Main () =
        Div [
            Canvas.Create(480, 480, Boids.Animate)
        ]
