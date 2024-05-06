```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3527/23H2/2023Update/SunValley3)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                       | Mean    | Error    | StdDev   | Max     | Rank | Gen0        | Gen1       | Gen2      | Allocated  |
|--------------------------------------------- |--------:|---------:|---------:|--------:|-----:|------------:|-----------:|----------:|-----------:|
| LoadAll_With_EagerLoading                    | 5.688 s | 0.2125 s | 0.0116 s | 5.697 s |    3 | 221000.0000 | 60000.0000 | 6000.0000 |  1450.1 MB |
| LoadAll_With_EagerLoading_Using_AsNoTracking | 2.457 s | 0.7343 s | 0.0402 s | 2.496 s |    1 | 143000.0000 | 22000.0000 | 1000.0000 |  851.77 MB |
| LoadAll_With_EagerLoading_Using_AsSplitQuery | 4.871 s | 1.5075 s | 0.0826 s | 4.940 s |    2 | 187000.0000 | 67000.0000 | 5000.0000 | 1302.75 MB |
