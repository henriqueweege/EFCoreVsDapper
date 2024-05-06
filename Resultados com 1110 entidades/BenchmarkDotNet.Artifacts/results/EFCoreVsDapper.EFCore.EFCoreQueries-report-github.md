```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3527/23H2/2023Update/SunValley3)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                       | Mean     | Error    | StdDev    | Max      | Rank | Gen0     | Gen1     | Allocated  |
|--------------------------------------------- |---------:|---------:|----------:|---------:|-----:|---------:|---------:|-----------:|
| LoadAll_With_EagerLoading                    | 5.655 ms | 1.925 ms | 0.1055 ms | 5.775 ms |    2 | 328.1250 | 250.0000 | 1632.95 KB |
| LoadAll_With_EagerLoading_Using_AsNoTracking | 5.721 ms | 1.227 ms | 0.0673 ms | 5.787 ms |    3 | 296.8750 |  62.5000 |  963.26 KB |
| LoadAll_With_EagerLoading_Using_AsSplitQuery | 5.147 ms | 1.667 ms | 0.0914 ms | 5.232 ms |    1 | 312.5000 | 171.8750 |  1497.6 KB |
