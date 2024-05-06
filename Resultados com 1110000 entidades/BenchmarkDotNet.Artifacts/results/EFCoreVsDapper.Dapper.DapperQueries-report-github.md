```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3527/23H2/2023Update/SunValley3)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                  | Mean      | Error   | StdDev  | Max       | Rank | Gen0        | Gen1       | Gen2      | Allocated  |
|---------------------------------------- |----------:|--------:|--------:|----------:|-----:|------------:|-----------:|----------:|-----------:|
| LoadAll_With_Dapper_Using_QueryMultiple |   644.6 s | 322.5 s | 17.68 s |   664.5 s |    1 |  42000.0000 | 19000.0000 | 4000.0000 |  209.09 MB |
| LoadAll_With_Dapper_Using_OneQuery      | 1,380.0 s | 349.2 s | 19.14 s | 1,391.4 s |    2 | 300000.0000 | 81000.0000 | 7000.0000 | 1002.15 MB |
