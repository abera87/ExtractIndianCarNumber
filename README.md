# Extract Indian Car Number
## Input
we can put any string as input from where it will extract only mached INdian car number. like below we input 3 numbers with smape and without space
"WB02AH3095 WB10A3457WB78GF3001"

## Output
WB02AH3095 <br>
WB10A3457 <br>
WB78GF3001 <br>
### Tech

* [dot net core]
* [VS code]
* [C#]
* [XUnit](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test) -- for unit testing

### Create project
open command prompt
for console project
```sh
> dotnet new console ExtractCarNumber
```
for test project
```sh
> dotnet new xunit -o ExtractCarNumberTests
```
### Run project
for console project
```sh
> dotnet run
```
for test project
```sh
> dotnet test
```
   [dot net core]: <https://dotnet.microsoft.com/download>
   [VS code]: <https://code.visualstudio.com/download>
   [C#]: <https://docs.microsoft.com/en-us/dotnet/csharp/>
