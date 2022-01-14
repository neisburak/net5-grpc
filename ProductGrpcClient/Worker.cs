using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProductGrpcClient.Protos;
using ProductGrpcClient.Services;

namespace ProductGrpcClient
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ProductService _productService;

        public Worker(ILogger<Worker> logger, ProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // The following statement allows you to call insecure services. To be used only in development environments.
                AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            }

            while (!stoppingToken.IsCancellationRequested)
            {
                // With metdod 1 (Requires Google.Protobuf, Grpc.Net.Client, Grpc.Tools)
                // using var channel = GrpcChannel.ForAddress("http://localhost:5000");
                // var client = new ProductProtoService.ProductProtoServiceClient(channel);
                // var product = await client.GetProductAsync(new GetProductRequest { Id = 1 });

                // With method 2 (Required Grpc.AspNetCore packages and .AddGrpcClient())
                try
                {
                    var product = await _productService.GetProduct(10);
                    _logger.LogInformation($"GetProduct Response: {product}");
                }
                catch (RpcException ex)
                {
                    if (ex.StatusCode == StatusCode.NotFound)
                    {
                        var product = await _productService.GetProduct(1);
                        _logger.LogInformation($"GetProduct Response: {product}");
                    }
                    else
                    {
                        throw;
                    }
                }

                var products = await _productService.GetProducts();
                _logger.LogInformation($"GetProducts Response: {products}");

                var insertProduct = await _productService.InsertProduct(new InsertProductRequest
                {
                    Product = new ProductModel
                    {
                        Id = 5,
                        Name = "Arabax",
                        Detail = "Arabax Açıklaması",
                        Price = 1999.99f,
                        Status = ProductStatus.InStock,
                        CreatedOn = Timestamp.FromDateTime(DateTime.UtcNow)
                    }
                });
                _logger.LogInformation($"InsertProduct Response: {insertProduct}");

                var updateProduct = await _productService.UpdateProduct(new UpdateProductRequest
                {
                    Product = new ProductModel
                    {
                        Id = 5,
                        Name = "Araba",
                        Detail = "Araba Açıklaması",
                        Price = 1990f,
                        Status = ProductStatus.Low,
                        CreatedOn = Timestamp.FromDateTime(DateTime.UtcNow)
                    }
                });
                _logger.LogInformation($"UpdateProduct Response: {updateProduct}");

                var removeProduct = await _productService.RemoveProduct(5);
                _logger.LogInformation($"RemoveProduct Response: {removeProduct}");

                var bulkInsert = await _productService.BulkInsertProduct(new List<ProductModel>
                {
                    new ProductModel {Id = 5, Name = "Araba", Detail = "Araba Açıklaması", Price = 1990, Status = ProductStatus.InStock, CreatedOn = Timestamp.FromDateTime(DateTime.UtcNow)},
                    new ProductModel {Id = 6, Name = "Ev", Detail = "Ev Açıklaması", Price = 11990, Status = ProductStatus.InStock, CreatedOn = Timestamp.FromDateTime(DateTime.UtcNow)},
                });
                _logger.LogInformation($"BulkInsertProduct Response: {bulkInsert}");


                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
