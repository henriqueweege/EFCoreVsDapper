```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3527/23H2/2023Update/SunValley3)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                  | Mean     | Error     | StdDev   | Max      | Rank | Gen0      | Gen1     | Gen2     | Allocated |
|---------------------------------------- |---------:|----------:|---------:|---------:|-----:|----------:|---------:|---------:|----------:|
| LoadAll_With_Dapper_Using_QueryMultiple | 32.53 ms |  1.762 ms | 0.097 ms | 32.61 ms |    1 |  333.3333 | 133.3333 |  66.6667 |   2.18 MB |
| LoadAll_With_Dapper_Using_OneQuery      | 93.99 ms | 35.298 ms | 1.935 ms | 96.20 ms |    2 | 1600.0000 | 600.0000 | 200.0000 |  10.31 MB |
