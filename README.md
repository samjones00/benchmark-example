# BenchmarkDotnet Example

An example of using `BenchmarkDotnet` to compare performance of multiple methods, in this case the performance difference between using Linq and iteration to sum an array of integers.

|  Method |      Mean |     Error |    StdDev |
|-------- |----------:|----------:|----------:|
|    Linq | 44.962 ns | 0.5980 ns | 0.5594 ns |
| ForEach |  5.291 ns | 0.0383 ns | 0.0339 ns |

### Creating a benchmark project manually

Nuget:  
1. Create a new project, using code in this repo as a template
2. Install the nuget package using `dotnet add package BenchmarkDotnet`
3. Set the build to `RELEASE` mode

### Creating a benchmark project using templates

1. Install this templates by running the command `dotnet new --install BenchmarkDotNet.Templates::0.13.1`
2. Create a new benchmark project using the dotnet command `dotnet new benchmark --console-app --name MyBenchmarkProject`
3. Add your benchmarks, some empty ones have been created by default.
4. Execute `dotnet run` from the new project directory

The tests will begin to execute

Reference: 

https://benchmarkdotnet.org/ 

https://benchmarkdotnet.org/articles/guides/dotnet-new-templates.html 
