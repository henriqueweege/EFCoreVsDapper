using BenchmarkDotNet.Attributes;
using EFCoreVsDapper.EFCore.Context;
using EFCoreVsDapper.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreVsDapper.EFCore
{
    [ShortRunJob]
    [RankColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class EFCoreQueries
    {
        
        [Benchmark]
        public void LoadAll_With_EagerLoading()
        {
            List<SchoolModel> schools;
            using (var Context = new EFContext())
            {
                schools = Context.Schools
                            .Include(x => x.Teachers)
                                .ThenInclude(x => x.Students)
                                .ToList();
            }
        }

        [Benchmark]
        public void LoadAll_With_EagerLoading_Using_AsNoTracking()
        {
            List<SchoolModel> schools;
            using (var Context = new EFContext())
            {
                schools = Context.Schools
                            .Include(x => x.Teachers)
                                .ThenInclude(x => x.Students)
                                .AsNoTracking()
                                .ToList();
            }

        }

        [Benchmark]
        public void LoadAll_With_EagerLoading_Using_AsSplitQuery()
        {
            List<SchoolModel> schools;
            using (var Context = new EFContext())
            {
                schools = Context.Schools
                            .Include(x => x.Teachers)
                                .ThenInclude(x => x.Students)
                                .AsSplitQuery()
                                .ToList();
            }
        }

    }
}
