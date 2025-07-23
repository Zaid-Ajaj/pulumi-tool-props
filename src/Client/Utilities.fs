[<AutoOpen>]
module Utilities

open Feliz
open Feliz.Markdown
open Fable.Core

[<ReactComponent>]
let Div(className: string, children: ReactElement list) =
    Html.div [
        prop.className className
        prop.children children
    ]

[<Emit "navigator.clipboard.writeText($0)">]
let copyToClipboard (text: string) : unit = jsNative

[<ReactComponent(import="default", from="react-highlight")>]
let Highlight(className: string, children: ReactElement array) : ReactElement = jsNative

[<ReactComponent>]
let MarkdownContent(sourceMarkdown: string) =
    Div("content", [
        Markdown.markdown [
            markdown.children sourceMarkdown
            markdown.components [
                markdown.components.pre (fun props -> React.fragment props.children)
                markdown.components.code (fun props ->
                    if props.isInline
                    then Html.code props.children
                    else Highlight(props.className, props.children)
                )
            ]
        ]
    ])

[<ReactComponent>]
let Tab(title: string, value: string, selectedTab, onClick: string -> unit) =
    Html.li [
        prop.className (if selectedTab = value then "is-active" else "")
        prop.children [
            Html.a [
                prop.onClick (fun _ -> onClick value)
                prop.text title
            ]
        ]
    ]

let Tabs(children: ReactElement list) =
    Div("tabs", [
        Html.ul children
    ])