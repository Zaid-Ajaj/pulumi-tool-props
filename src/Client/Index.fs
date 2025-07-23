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
                prop.text $" using Pulumi {version} | Tool v0.1.0"
            ]
        ]

    | _ ->
        Html.div "Pulumi Provider Operations"

[<ReactComponent>]
let GithubTriageTile() = Html.div [
    prop.onClick (fun _ -> Router.navigate "triage")
    prop.children [
        Html.img [
            prop.src "https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png"
            prop.style [
                style.marginTop 15
                style.height 50
                style.width 100
            ]
        ]
    ]

    prop.style [
        style.margin 10
        style.fontSize 20
        style.height 100
        style.width 200
        style.cursor.pointer
        style.textAlign.center
        style.display.inlineBlock
        style.position.relative
        style.overflow.hidden
        style.paddingTop 10
        style.border(2, borderStyle.solid, color.black)
        style.boxShadow(0, 0, 2, 0, color.black)
    ]
]

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

                Html.span "Address issues that need triage in Pulumi orginazation"
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
let GithubTriage() = Html.div [
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
                        GithubTriage()
                    | _ -> 
                        Home()
               ]
            ]
        ]
    ]