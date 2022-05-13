var startTime = DateTime.Now;
var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
string banner = @$"
  __  __                                                        _    _____           _                                     
 |  \/  |                                       /\             (_)  / ____|         | |                                    
 | \  / |   __ _   _ __    ___    ___          /  \     _ __    _  | |  __    __ _  | |_    ___  __      __   __ _   _   _ 
 | |\/| |  / _` | | '__|  / __|  / _ \        / /\ \   | '_ \  | | | | |_ |  / _` | | __|  / _ \ \ \ /\ / /  / _` | | | | |
 | |  | | | (_| | | |    | (__  | (_) |  _   / ____ \  | |_) | | | | |__| | | (_| | | |_  |  __/  \ V  V /  | (_| | | |_| |
 |_|  |_|  \__,_| |_|     \___|  \___/  (_) /_/    \_\ | .__/  |_|  \_____|  \__,_|  \__|  \___|   \_/\_/    \__,_|  \__, |
                                                       | |                                                            __/ |
                                                       |_|                                                           |___/ 

Version: {version}

Started: {startTime:s}
===========================================================================================================================
";
Console.WriteLine(banner);

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

app.MapReverseProxy();
app.MapGet("/", () => banner);

app.Run();
