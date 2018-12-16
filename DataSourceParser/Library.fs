namespace DataSourceParser

module Say =

    open System
    open System.Net

    let fetchUrl callback url =        
        let req = WebRequest.Create(Uri(url)) 
        use resp = req.GetResponse() 
        use stream = resp.GetResponseStream() 
        use reader = new IO.StreamReader(stream) 
        callback reader url

    let myCallback (reader:IO.StreamReader) url = 
        let html = reader.ReadToEnd()
        let html1000 = html.Substring(0,1000)
        printfn "Downloaded %s. First 1000 is %s" url html1000
        html 

    let google = fetchUrl myCallback "http://google.com"

    let fetchUrl2 = fetchUrl myCallback 

    let google2 = fetchUrl2 "http://www.google.com"
    let bbc    = fetchUrl2 "http://news.bbc.co.uk"

    let sites = ["http://www.bing.com";
                    "http://www.google.com";
                    "http://www.yahoo.com"]

    let r2 = sites |> List.map fetchUrl2 
