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
            Html.div "Pulumi Tool"
            Html.div [
                prop.style [ style.fontSize 13; style.marginTop 10; style.marginLeft 10 ]
                prop.text $" using Pulumi {version} | Tool v0.1.0"
            ]
        ]

    | _ ->
        Html.div "Pulumi Tool"

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
                    | _ ->
                        Html.p [
                            prop.text "Start implementing your Pulumi Tool here!"
                            prop.className "subtitle"
                        ]
                 ]
            ]
        ]
    ]