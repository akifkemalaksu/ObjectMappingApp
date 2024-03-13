using AgileObjects.AgileMapper.Extensions;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Order;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Nelibur.ObjectMapper;
using ObjectMappingApp.Context;
using ObjectMappingApp.Dtos;
using ObjectMappingApp.Entities;
using ObjectMappingApp.Services.Mapping;
using ObjectMappingApp.Services.Mapping.AutoMapper;
using System.Diagnostics;

namespace ObjectMappingApp
{
    [MemoryDiagnoser] // memory test
    //[HardwareCounters(HardwareCounter.BranchMispredictions, HardwareCounter.BranchInstructions)] // cpu test
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ObjectMapperBenchmark
    {
        private List<OrderItem> _list;
        public ObjectMapperBenchmark()
        {
            using var context = new MappingContext();
            _list = context.OrderItems
                .Include(x => x.Order)
                    .ThenInclude(x => x.Customer)
                .Include(x => x.Order)
                    .ThenInclude(x => x.Store)
                .Include(x => x.Order)
                    .ThenInclude(x => x.Staff)
                        .ThenInclude(x => x.Store)
                .Include(x => x.Product)
                    .ThenInclude(x => x.Brand)
                .Include(x => x.Product)
                    .ThenInclude(x => x.Category)
                .ToList();

            Debug.WriteLine($"list sayısı: {_list.Count}");
        }

        [Benchmark]
        public void WithAutoMapper()
        {
            var autoMapper = new AutoMapper.Mapper(new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()));
            autoMapper.Map<List<OrderItemDto>>(_list);
        }

        [Benchmark]
        public void WithMapster()
        {
            _list.Adapt<List<OrderItemDto>>();
        }

        [Benchmark]
        public void WithAgileMapper()
        {
            _list.Map().ToANew<List<OrderItemDto>>();
        }

        [Benchmark]
        public void WithTinyMapper()
        {
            TinyMapper.Map<List<OrderItemDto>>(_list);
        }
    }
}
