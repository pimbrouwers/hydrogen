#r "nuget: NUglify, 1.21.11"

open System.IO
open System.Text
open System.Text.RegularExpressions
open NUglify

let libName = "hydrogen"

let breakpoints =
    [
      "-l", "48em"
    ]

let cssFiles =
    [
        "_root.css"
        "_normalize.css"
        "base.css"
        "display.css"
        "flexbox.css"
        "sizing.css"
        "spacing.css"
        "position.css"
        "float.css"
        "aspect-ratio.css"
        "text.css"
        "background.css"
        "border.css"
        "layout.css"
        "button.css"
        "form.css"
        "colour.css"
        "opacity.css"
    ]

let cssBreakpointFiles =
    [
        "display.css"
        "flexbox.css"
        "sizing.css"
        "spacing.css"
        "position.css"
        "float.css"
        "aspect-ratio.css"
        "text.css"
        "background.css"
        "border.css"
    ]

let sb = StringBuilder()

let append (x : string) = sb.AppendLine(x) |> ignore
let appendLine () = sb.AppendLine() |> ignore

cssFiles
|> List.map (fun cssPath ->
    let cssContent = File.ReadAllText(Path.Join(__SOURCE_DIRECTORY__, "css", cssPath))
    append cssContent
    appendLine ()
    cssPath, cssContent)
|> List.filter (fun (cssPath, _) -> List.contains cssPath cssBreakpointFiles)
|> List.map snd
|> String.concat "\n\n"
|> fun breakpointCss ->
    for (suffix, width) in breakpoints do
        let breakpointCssAtoms =
            Regex.Replace(
                input = breakpointCss,
                pattern = @"^(\.[\w\-\d]+)",
                replacement = $"  $1{suffix}",
                options = RegexOptions.Multiline)

        append $"@media screen and (min-width: {width}) {{"
        append breakpointCssAtoms
        append "}"

let css = sb.ToString()
File.WriteAllText (Path.Join(__SOURCE_DIRECTORY__, $"{libName}.css"), css)
File.WriteAllText (Path.Join(__SOURCE_DIRECTORY__, $"{libName}.min.css"), Uglify.Css(css).Code)
