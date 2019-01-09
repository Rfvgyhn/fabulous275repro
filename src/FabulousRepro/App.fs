namespace FabulousRepro

open Fabulous.Core
open Fabulous.DynamicViews
open Xamarin.Forms

module App =
    type Model = { Prop : string }
    let initModel = { Prop = "" }
    let init () = initModel, Cmd.none    
    let update msg model = model, Cmd.none
    let view (model: Model) dispatch = View.ContentPage(content = View.Label("can't"))

type App () as app = 
    inherit Application ()
    
    let runner =
        Program.mkProgram App.init App.update App.view
#if DEBUG
        |> Program.withConsoleTrace
#endif
        |> Program.runWithDynamicView app



