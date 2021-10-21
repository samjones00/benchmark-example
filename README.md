# BenchmarkDotnet Example

An example of using `BenchmarkDotnet` to compare performance of multiple methods, in this case the performance difference between using Linq and iteration to sum an array of integers.

|  Method |      Mean |     Error |    StdDev |
|-------- |----------:|----------:|----------:|
|    Linq | 44.962 ns | 0.5980 ns | 0.5594 ns |
| ForEach |  5.291 ns | 0.0383 ns | 0.0339 ns |


Nuget:  
`dotnet add package BenchmarkDotnet`

Reference: 
https://benchmarkdotnet.org/
