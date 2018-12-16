namespace GenerationalListOfProgrammingLanguages

open System
open System.Collections.Generic
open System.IO
open System.Net
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.Logging
open DataSourceParser;

module Program =
    open DataSourceParser

    let exitCode = 0

    let CreateWebHostBuilder args =
        WebHost
            .CreateDefaultBuilder(args)
            .UseStartup<Startup>();            

    [<EntryPoint>]
    let main args =

        Say.google

        CreateWebHostBuilder(args).Build().Run()

        exitCode
