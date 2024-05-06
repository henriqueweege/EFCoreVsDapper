```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3527/23H2/2023Update/SunValley3)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                       | Mean     | Error     | StdDev   | Max      | Rank | Gen0       | Gen1       | Gen2      | Allocated |
|--------------------------------------------- |---------:|----------:|---------:|---------:|-----:|-----------:|-----------:|----------:|----------:|
| LoadAll_With_EagerLoading                    | 614.3 ms |  91.44 ms |  5.01 ms | 619.7 ms |    3 | 23000.0000 |  7000.0000 | 1000.0000 | 147.02 MB |
| LoadAll_With_EagerLoading_Using_AsNoTracking | 312.9 ms | 237.29 ms | 13.01 ms | 321.0 ms |    1 | 15000.0000 |  2500.0000 |  500.0000 |  85.25 MB |
| LoadAll_With_EagerLoading_Using_AsSplitQuery | 540.4 ms | 265.78 ms | 14.57 ms | 553.3 ms |    2 | 21000.0000 | 10000.0000 | 4000.0000 | 133.62 MB |
