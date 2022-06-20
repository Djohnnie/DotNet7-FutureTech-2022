using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();
services.AddMemoryCache(o =>
{
    o.TrackStatistics = true;
    o.SizeLimit = Int32.MaxValue;
});

var serviceProvider = services.BuildServiceProvider();
var cache = serviceProvider.GetService<IMemoryCache>();

cache.Set("h", "Hello world");

var statistics = cache.GetCurrentStatistics();

Console.WriteLine(statistics.CurrentEntryCount);
Console.WriteLine(statistics.CurrentEstimatedSize);
Console.WriteLine(statistics.TotalHits);
Console.WriteLine(statistics.TotalMisses);