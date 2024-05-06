```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3527/23H2/2023Update/SunValley3)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                  | Mean    | Error    | StdDev   | Max     | Rank | Gen0       | Gen1      | Gen2      | Allocated |
|---------------------------------------- |--------:|---------:|---------:|--------:|-----:|-----------:|----------:|----------:|----------:|
| LoadAll_With_Dapper_Using_QueryMultiple | 4.662 s | 0.4422 s | 0.0242 s | 4.685 s |    1 |  3000.0000 | 1000.0000 |         - |  21.34 MB |
| LoadAll_With_Dapper_Using_OneQuery      | 6.363 s | 3.8981 s | 0.2137 s | 6.608 s |    2 | 16000.0000 | 6000.0000 | 2000.0000 | 101.57 MB |
