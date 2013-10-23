This is the starter code for D.C. area F# Meetup on October 23, 2013.
It showcases building simple interactive browser animations
with F#/WebSharper.

The starter code implements the **boids**, a simple artificial bird flocking algorithm
in F#/WebSharper running natively in the browser in JavaScript over Canvas. We hope to
get creative tweaking the code over the course of the session.

## Key Points

* JavaScript is the new portable assembly language
* F# much more *fun* to work with than JavaScript, no?
* F# gives types without making you type them..
* WebSharper makes using F# for both server (CLR) and client (JS) easy
* Starting from screwed up imperative APIs (Canvas), it is easy to "functionalize" a bit in F#
* Performance on modern browsers surprisingly good without optimization
* Can use meta-programming to get more performance

## Requirements

* Visual Studio 2012/2013 (Express for Web or one of the professional editions)
* F# 3.0
* NuGet package manager 2.7+
* [WebSharper (2.5-alpha+)](http://github.com/intellifactory/websharper)

## Building

Restore packages with `nuget.exe restore`, or by opening the solution
in Visual Studio. Unfortunately due to an issue with NuGet, opening in
VS requires a studio restart after the packages are restored.

Press F5, the demo should show up in the browser.

## Code Walkthrough


* `Vectors2D.fs` - simple vector arithmetic with `d = 2`
* `Shapes.fs` - functional "shape" abstraction as an alternative to the Canvas interface
* `Client.fs` - entry-point of the app, generating some DOM nodes and behaviors
* `Extensions.fs` - helper methods missing from standard library
* `Boids.fs` - the boids flocking model
* `Remoting.fs` - RPC boilerplate
* `Main.fs` - server-side boilerplate
* `Main.html` - wrapper template for the app
