```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3527/23H2/2023Update/SunValley3)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                  | Mean       | Error      | StdDev    | Max        | Rank | Gen0     | Gen1    | Allocated  |
|---------------------------------------- |-----------:|-----------:|----------:|-----------:|-----:|---------:|--------:|-----------:|
| LoadAll_With_Dapper_Using_QueryMultiple |   764.0 μs |   294.6 μs |  16.15 μs |   781.0 μs |    1 |  71.2891 |       - |  219.07 KB |
| LoadAll_With_Dapper_Using_OneQuery      | 2,985.0 μs | 5,089.7 μs | 278.98 μs | 3,258.3 μs |    2 | 312.5000 | 97.6563 | 1059.21 KB |
