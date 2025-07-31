module Server.Tests

open System.Collections.Generic
open System.IO
open System.Linq
open Expecto
open Shared
open Server

let all = testList "All" [
    testCase "parseWorkflowUrls works on pulumi-bot issue" <| fun _ ->
        // https://github.com/pulumi/automation-api-examples/issues/85
        let issueBody = """
 ## Workflow Failure

[Run Automation API Examples](https://github.com/pulumi/automation-api-examples/blob/main/.github/workflows/ci.yml) has failed. See the list of failures below:

- [2025-07-25T16:38:21.000Z](https://github.com/pulumi/automation-api-examples/actions/runs/16526722537)
        """
        let workflowUrls = parseWorkflowUrls issueBody
        Expect.equal (Map.count workflowUrls) 1 "Expected one workflow URL to be found"
        Expect.equal (Map.find "2025-07-25T16:38:21.000Z" workflowUrls) "https://github.com/pulumi/automation-api-examples/actions/runs/16526722537" "Expected the correct workflow URL to be found"

    testCase "logs URL can be derived from workflow URL" <| fun _ ->
        let workflowUrl = "https://github.com/pulumi/automation-api-examples/actions/runs/16526722537"
        let logsUrl = logsUrlFromWorkflowUrl workflowUrl
        Expect.equal logsUrl (Some "https://api.github.com/repos/pulumi/automation-api-examples/actions/runs/16526722537/logs") "Expected the correct logs URL to be found"

    // testCaseAsync "downloadWorkflowLogs returns Ok with entries" <| async {
    //     let workflowUrl = "https://github.com/pulumi/automation-api-examples/actions/runs/16526722537"
    //     let! result = Async.AwaitTask (downloadWorkflowLogs (workflowUrl, 0))
    //     match result with
    //     | Ok content ->
    //         Expect.isNotEmpty content "Expected log content to be found"
    //     | Error errorMessage ->
    //         failwith $"Failed to download workflow logs: {errorMessage}"
    // }
]

[<EntryPoint>]
let main _ = runTestsWithCLIArgs [] [||] all