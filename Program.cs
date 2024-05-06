using BenchmarkDotNet.Running;
using EFCoreVsDapper.Dapper;
using EFCoreVsDapper.EFCore;


BenchmarkRunner.Run<DapperQueries>();
BenchmarkRunner.Run<EFCoreQueries>();