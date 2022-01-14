using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductGrpcClient.Protos;
using ProductGrpcClient.Services;

namespace ProductGrpcClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddGrpcClient<ProductProtoService.ProductProtoServiceClient>(options =>
                    {
                        options.Address = new Uri("http://localhost:5000");
                    });

                    services.AddTransient<ProductService>();

                    services.AddHostedService<Worker>();
                });
    }
}
