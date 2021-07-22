open System.IO
let all=("zh_CN.lang"|>File.ReadAllText).Replace("\r","").Split('\n')
let html=System.Text.StringBuilder()
let (!+)(s:string)=html.AppendLine(s)
!+"""<!DOCTYPE html>
<html lang="zh-CN">
<head><meta charset="utf-8"><title>PFEssential Language File</title></head>
<body>"""
Array.map (fun (x:string)-> 
    let i=x.IndexOf("=")
    let mutable line= $"<li><a translate=\"no\">{x.[..i]}</a>{x.[i+1..]}</li>" 
    for m in System.Text.RegularExpressions.Regex.Matches(line,"¡ì.|{.+?}|\\n") do
        line <- line.Replace(m.Value,$"<a translate=\"no\">{m.Value}</a>")
    !+ line
) all
!+"</body></html>"
("zh_CN.html",html.ToString())
|>File.WriteAllText