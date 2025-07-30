module Index

open Feliz
open Feliz.UseDeferred
open Feliz.Router
open Shared

[<ReactComponent>]
let PulumiTitleWithVersion() =
    let response = React.useDeferred(Server.api.getPulumiVersion(), [|  |])
    match response with
    | Deferred.Resolved version ->
        React.fragment [
            Html.div "Pulumi Provider Operations"
            Html.div [
                prop.style [ style.fontSize 13; style.marginTop 10; style.marginLeft 10 ]
                prop.text $" using Pulumi {version} | Tool v0.4.0"
            ]
        ]

    | _ ->
        Html.div "Pulumi Provider Operations"

[<ReactComponent>]
let Home() = Html.div [
    prop.style [ style.margin 20 ]
    prop.children [
        Html.p [
            prop.text "AI-assisted provider operations for Pulumi"
            prop.className "subtitle"
        ]

        Html.p [
            prop.text "Uses GITHUB_TOKEN || 'gh auth login' to access GitHub on your behalf"
            prop.className "subtitle"
        ]

        Html.p [
            prop.style [ style.fontSize 18 ]
            prop.children [
                Html.a [
                    prop.href "/#triage"
                    prop.style [ style.marginRight 5 ]
                    prop.children [
                        Html.i [
                            prop.className "fa fa-chevron-right"
                            prop.style [ style.marginRight 5  ]
                        ]
                        Html.text "GitHub Triage"
                    ]
                ]

                Html.span "Address issues that need triage in Pulumi organization"
            ]
        ]
    ]
]

[<ReactComponent>]
let CurrentGithubUser() = 
    let response = React.useDeferred(Server.api.currentGithubUser(), [|  |])
    let fontSize = 14
    match response with
    | Deferred.HasNotStartedYet -> 
        Html.span "..."
    | Deferred.Resolved (Ok user) ->
        Html.span [
            prop.style [ style.fontSize fontSize ]
            prop.text user.login
        ]

    | Deferred.Resolved (Error error) ->
        Html.span [
            prop.style [ style.fontSize fontSize; style.color.red ]
            prop.text error
        ]

    | Deferred.InProgress ->
        Html.i [
            prop.className "fa fa-spinner fa-spin"
            prop.style [ style.fontSize fontSize ]
        ]

    | Deferred.Failed error ->
        Html.span [
            prop.style [ style.fontSize fontSize; style.color.red ]
            prop.text $"Error: {error.Message}"
        ]

[<ReactComponent>]
let IssueLabel(label: string) =
    let (bg, fg) = 
        match label with
        | "needs-triage" -> "green", "white"
        | "p0" | "p1" -> "red", "white"
        | "tier 1" 
        | "tier 2" -> "orange", "black"
        | _ -> "lightblue", "black"
    Html.span [
        prop.text label
        prop.style [ 
            style.fontSize 9
            style.fontWeight.bold
            style.marginRight 5
            style.backgroundColor bg
            style.borderRadius 3
            style.color fg
            style.padding 3 
        ]
    ]

[<ReactComponent>]
let AgeInHours (date: System.DateTime) =
    let now = System.DateTime.Now
    let age = now - date
    Html.span [
        prop.style [ style.fontSize 10; style.color.gray; style.marginLeft 5 ]
        prop.text $"({int age.TotalHours} hours ago)"
    ]

[<ReactComponent>]
let WorkflowDetails (workflowUrl: string) = 
    let response = React.useDeferred(Server.api.workflowDetails workflowUrl, [| workflowUrl |])
    match response with
    | Deferred.HasNotStartedYet -> 
        Html.none
    
    | Deferred.InProgress ->
        Html.div [
            Html.i [ prop.className "fa fa-spinner fa-spin" ]
        ]

    | Deferred.Failed error ->
        Html.div [
            prop.style [ style.color.red ]
            prop.text $"Error: {error.Message}"
        ]

    | Deferred.Resolved (Error error) ->
        Html.div [
            prop.style [ style.color.red ]
            prop.text $"Error: {error}"
        ]

    | Deferred.Resolved (Ok details) ->
        Html.div [
            Html.p $"Status: {details.status} | Conclusion: {details.conclusion}"
            for run in details.checkRuns do
            Html.p [
                Html.span [
                    prop.style [
                        if run.conclusion <> "Success" 
                        then style.color.red
                        elif run.conclusion = "Skipped"
                        then style.color.gray
                        else style.color.green

                        style.textDecoration.underline
                        style.cursor.pointer
                    ]

                    prop.children [
                        if run.conclusion <> "Success"  
                        then Html.li [ prop.style [ style.marginRight 10 ]; prop.className "fa fa-times" ]
                        else Html.li [ prop.style [ style.marginRight 5 ]; prop.className "fa fa-check" ]

                        Html.span [
                            prop.style [ style.marginRight 5 ]
                            prop.text run.name
                        ]
                    ]
                ]
            ]
        ]

[<ReactComponent>]
let PulumiWorkflowFailuresList(failedWorkflows: Map<string, string>) =
    let selectedWorkflow, selectWorkflow = React.useState<(string*string) option>(None)
    match selectedWorkflow with
    | Some (title, url) ->
        Html.div [
            Html.span [
                prop.style [ style.fontSize 12 ]
                prop.children [
                    Html.text $"Selected: {title}"
                    Html.button [
                        prop.className "button is-small"
                        prop.style [ style.marginLeft 10; style.fontSize 10 ]
                        prop.text "Back"
                        prop.onClick (fun _ -> selectWorkflow None)
                    ]
                ]
            ]

            WorkflowDetails url
        ]

    | None ->
        Html.div [
            for title, url in Map.toList failedWorkflows do
            Html.p [
                prop.style [ 
                    style.fontSize 12 
                    style.cursor.pointer
                    style.textDecoration.underline
                    style.color "#3273dc"
                ]
                prop.onClick (fun _ -> selectWorkflow(Some (title, url)))
                prop.children [
                    Html.i [
                        prop.className "fa fa-chevron-right"
                        prop.style [ style.marginRight 5  ]
                    ]
                    Html.text title
                ]
            ]
        ]

[<ReactComponent>]
let IssueDetails(issueId: string) =
    let response = React.useDeferred(Server.api.issueDetails(issueId), [| issueId |])
    match response with
    | Deferred.HasNotStartedYet -> 
        Html.none
    | Deferred.InProgress ->
        Html.i [
            prop.className "fa fa-spinner fa-spin"
        ]
    | Deferred.Failed error ->
        Html.div [
            prop.style [ style.color.red ]
            prop.text $"Error: {error.Message}"
        ]
    | Deferred.Resolved (Error error) ->
        Html.div [
            prop.style [ style.color.red ]
            prop.text $"Error: {error}"
        ]
    | Deferred.Resolved (Ok issue) ->
        Html.div [
            prop.className "content"
            prop.children [
                Html.h3 issue.title
                Html.div [
                    Html.span "by "
                    Html.span [
                        Html.a [
                            prop.text $"@{issue.author}"
                            prop.href $"http://github.com/{issue.author}"
                            prop.target "_blank"
                        ]
                    ]

                    if issue.assignees.Length > 0 then
                        Html.span " | Assignees: "
                        issue.assignees
                        |> String.concat ", "
                        |> Html.span
                ]
                Html.hr [ ]
                if Map.isEmpty issue.pulumiBotWorkflowFailures then
                    Html.div [ prop.dangerouslySetInnerHTML issue.bodyHTML ]
                else
                    PulumiWorkflowFailuresList issue.pulumiBotWorkflowFailures
            ]
        ]

let filterIssues (issues: Shared.GithubIssue list) (filters: string list) =
    issues
    |> List.filter (fun issue ->
        let hasP0P1 = List.contains "p0/p1" filters && (issue.labels |> List.exists (fun l -> l = "p0" || l = "p1"))
        let hasTier1 = List.contains "tier1" filters && issue.tier = Some 1
        let hasTier2 = List.contains "tier2" filters && issue.tier = Some 2
        hasP0P1 || hasTier1 || hasTier2 || filters = [ ]
    )

[<ReactComponent>]
let TriageIssues() = 
    let response = React.useDeferred(Server.api.triageIssues(), [|  |])
    let (filters, setFilters) = React.useStateWithUpdater<string list> [ ]
    let (selectedIssue, setSelectedIssue) = React.useState<string option>(None)
    match response with
    | Deferred.HasNotStartedYet -> 
        Html.none

    | Deferred.InProgress ->
        Html.i [
            prop.className "fa fa-spinner fa-spin"
        ]

    | Deferred.Failed error ->
        Html.div [
            prop.style [ style.color.red ]
            prop.text $"Error: {error.Message}"
        ]
    
    | Deferred.Resolved (Error error) ->
        Html.div [
            prop.style [ style.color.red ]
            prop.text $"Error: {error}"
        ]

    | Deferred.Resolved (Ok issues) ->
        Html.div [
            prop.className "columns"
            prop.children [
                Html.div [
                    // showing issues in the first column
                    prop.className "column is-one-third"
                    prop.children [
                        Html.span "Filters "
                        Html.span [
                            Html.button [
                                prop.text "All"
                                prop.classes [ 
                                    "button"
                                    "is-small"
                                    if filters = [ ]
                                    then "is-primary"
                                ]
                                prop.style [ style.marginRight 5 ]
                                prop.onClick (fun _ -> setFilters(fun _ -> [ ]))
                            ]

                            Html.button [
                                prop.text "P0/P1"
                                prop.classes [ 
                                    "button"
                                    "is-small"
                                    if List.contains "p0/p1" filters 
                                    then "is-primary"
                                ]
                                prop.style [ style.marginRight 5 ]
                                prop.onClick (fun _ -> setFilters(fun current -> 
                                    if List.contains "p0/p1" current then
                                        List.filter (fun f -> f <> "p0/p1") current
                                    else
                                        List.distinct (current @ [ "p0/p1" ])))
                            ]

                            Html.button [
                                prop.text "Tier 1"
                                prop.classes [ 
                                    "button"
                                    "is-small"
                                    if List.contains "tier1" filters 
                                    then "is-primary"
                                ]
                                prop.style [ style.marginRight 5 ]
                                prop.onClick (fun _ -> setFilters(fun current -> 
                                    if List.contains "tier1" current then
                                        List.filter (fun f -> f <> "tier1") current
                                    else
                                        List.distinct (current @ [ "tier1" ])))
                            ]

                            Html.button [
                                prop.text "Tier 2"
                                prop.classes [ 
                                    "button"
                                    "is-small"
                                    if List.contains "tier2" filters 
                                    then "is-primary"
                                ]
                                prop.style [ style.marginRight 5 ]
                                prop.onClick (fun _ -> setFilters(fun current -> 
                                    if List.contains "tier2" current then
                                        List.filter (fun f -> f <> "tier2") current
                                    else
                                        List.distinct (current @ [ "tier2" ])))
                            ]
                        ]
                        
                        for issue in filterIssues issues filters do
                        Html.p [
                            prop.style [ 
                                style.fontSize 14 
                                if Some issue.id = selectedIssue 
                                then 
                                    style.border(1, borderStyle.groove, color.blue)
                                    style.borderRadius 3
                            ]
                            prop.children [
                                Html.div [
                                    prop.onClick (fun _ -> setSelectedIssue(Some issue.id))
                                    prop.style [ 
                                        style.marginRight 5
                                        style.marginTop 3
                                        style.marginBottom 5
                                        style.padding 5
                                        style.cursor.pointer 
                                    ]
        
                                    prop.children [
                                        Html.i [
                                            prop.className "fa fa-chevron-right"
                                            prop.style [ style.marginRight 5  ]
                                        ]
                                        Html.text issue.title

                                        AgeInHours issue.createdAt
                                    ]
                                ]

                                Html.div [
                                    prop.style [ style.paddingLeft 10; style.paddingBottom 5; style.fontSize 12; style.color.gray ]
                                    prop.children [
                                        Html.a [
                                            prop.style [ style.marginRight 5 ]
                                            prop.href issue.url
                                            prop.target "_blank"
                                            prop.text $"{issue.repository}#{issue.number}"
                                        ]

                                        Html.span [ for label in issue.labels -> IssueLabel label]

                                        match issue.tier with
                                        | Some tier -> IssueLabel $"tier {tier}"
                                        | None -> Html.none

                                        Html.span "by "
                                        Html.span [
                                            Html.a [
                                                prop.href $"https://github.com/{issue.author}"
                                                prop.target "_blank"
                                                prop.text $"@{issue.author}"
                                            ]
                                        ]                                        
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]

                Html.div [
                    // showing selected issue in the second column
                    prop.className "column"
                    prop.children [
                        match selectedIssue with
                        | None ->
                            Html.div "Select an issue to see details"
                        | Some issueId ->
                            IssueDetails issueId
                    ]
                ]
            ]
        ]


[<ReactComponent>]
let GithubTriagePage() = Html.div [
    prop.style [ style.margin 20 ]
    prop.children [
        Html.p [
            prop.className "subtitle"
            prop.children [
                Html.span "GitHub Triage ("
                CurrentGithubUser()
                Html.span ")"
            ]
        ]

        TriageIssues()
    ]
]

[<ReactComponent>]
let View() =
    let (currentUrl, setCurrentUrl) = React.useState(Router.currentUrl())
    Html.div [
        prop.style [ style.margin 20 ]
        prop.children [
            Html.span [
                prop.style [ style.fontSize 24; style.display.flex; style.justifyContent.left; style.alignContent.center ]
                prop.children [
                    Html.img [
                        prop.src "https://www.pulumi.com/logos/brand/avatar-on-white.png"
                        prop.style [ style.height 50; style.marginRight 20 ]
                    ]

                    PulumiTitleWithVersion()
                ]
            ]

            Html.hr [ ]

            React.router [
                router.onUrlChanged setCurrentUrl
                router.children [
                   match currentUrl with
                    | [ "triage" ] -> 
                        GithubTriagePage()
                    | _ -> 
                        Home()
               ]
            ]
        ]
    ]