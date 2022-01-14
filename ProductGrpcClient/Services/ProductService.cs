using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using ProductGrpcClient.Protos;

namespace ProductGrpcClient.Services
{
    public class ProductService
    {
        private readonly ProductProtoService.ProductProtoServiceClient _productProtoService;

        public ProductService(ProductProtoService.ProductProtoServiceClient productProtoService)
        {
            _productProtoService = productProtoService;
        }

        public async Task<ProductModel> GetProduct(int Id)
        {
            return await _productProtoService.GetProductAsync(new GetProductRequest { Id = Id });
        }

        public async Task<List<ProductModel>> GetProducts()
        {
            var products = new List<ProductModel>();

            using var productsData = _productProtoService.GetProducts(new Empty());

            await foreach (var product in productsData.ResponseStream.ReadAllAsync())
            {
                products.Add(product);
            }

            return products;
        }

        public async Task<ProductModel> InsertProduct(InsertProductRequest product)
        {
            return await _productProtoService.InsertProductAsync(product);
        }

        public async Task<ProductModel> UpdateProduct(UpdateProductRequest product)
        {
            return await _productProtoService.UpdateProductAsync(product);
        }

        public async Task<RemoveProductResponse> RemoveProduct(int Id)
        {
            return await _productProtoService.RemoveProductAsync(new RemoveProductRequest { Id = Id });
        }

        public async Task<BulkInsertProductResponse> BulkInsertProduct(List<ProductModel> products)
        {
            using var bulkInsert = _productProtoService.BulkInsertProduct();

            foreach (var product in products)
            {
                await bulkInsert.RequestStream.WriteAsync(product);
            }

            await bulkInsert.RequestStream.CompleteAsync();

            return await bulkInsert;
        }
    }
}