```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3527/23H2/2023Update/SunValley3)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                       | Mean     | Error    | StdDev   | Max      | Rank | Gen0      | Gen1      | Gen2     | Allocated |
|--------------------------------------------- |---------:|---------:|---------:|---------:|-----:|----------:|----------:|---------:|----------:|
| LoadAll_With_EagerLoading                    | 75.66 ms | 54.73 ms | 3.000 ms | 77.65 ms |    3 | 2000.0000 | 1000.0000 | 500.0000 |  14.99 MB |
| LoadAll_With_EagerLoading_Using_AsNoTracking | 34.23 ms | 18.62 ms | 1.020 ms | 34.87 ms |    1 | 1500.0000 |  333.3333 |        - |   8.61 MB |
| LoadAll_With_EagerLoading_Using_AsSplitQuery | 56.11 ms | 13.59 ms | 0.745 ms | 56.97 ms |    2 | 2000.0000 |  666.6667 | 333.3333 |  13.79 MB |
