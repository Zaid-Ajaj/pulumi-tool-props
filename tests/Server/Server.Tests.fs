module Server.Tests

open System.Collections.Generic
open System.IO
open System.Linq
open Expecto
open Shared
open Server

let all = testList "All" [ ]

[<EntryPoint>]
let main _ = runTestsWithCLIArgs [] [||] all