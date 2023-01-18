using IotaExplorerNet.Domain.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IotaExplorerNet.Domain.Common.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddIotaExplorerServices(this IServiceCollection serviceDescriptors)
        {
            
            serviceDescriptors
                .AddSingleton(testnetApiProvider => new Func<string, ITestnetExplorerApi>((url) => RestService.For<ITestnetExplorerApi>(url)));

            return serviceDescriptors;
        }
    }
}
