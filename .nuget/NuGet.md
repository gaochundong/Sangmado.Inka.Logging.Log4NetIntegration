Commands
------------
nuget setApiKey xxx-xxx-xxxx-xxxx

nuget pack ..\Sangmado.Inka.Logging.Log4NetIntegration\Sangmado.Inka.Logging.Log4NetIntegration.csproj -IncludeReferencedProjects -Symbols -Build -Prop Configuration=Release -OutputDirectory ".\packages"

nuget push .\packages\Sangmado.Inka.Logging.Log4NetIntegration.1.0.0.0.nupkg

