using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using ProductGrpc.Data;
using ProductGrpc.Models;
using ProductGrpc.Protos;

namespace ProductGrpc.Services
{
    public class ProductService : ProductProtoService.ProductProtoServiceBase
    {
        // Helper Methods
        private ProductModel GetFromProduct(Product product)
        {
            return new ProductModel
            {
                Id = product.Id,
                Name = product.Name,
                Detail = product.Detail,
                Price = product.Price,
                Status = (ProductGrpc.Protos.ProductStatus)product.Status,
                CreatedOn = Timestamp.FromDateTime(product.CreatedOn),
            };
        }
        private Product GetFromModel(ProductModel model)
        {
            return new Product
            {
                Id = model.Id,
                Name = model.Name,
                Detail = model.Detail,
                Price = model.Price,
                Status = (ProductGrpc.Models.ProductStatus)model.Status,
                CreatedOn = model.CreatedOn.ToDateTime()
            };
        }

        public override Task<ProductModel> GetProduct(GetProductRequest request, ServerCallContext context)
        {
            var product = Mock.Data.FirstOrDefault(f => f.Id == request.Id);
            if (product == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Product with Id: {request.Id} is not found."));
            }

            return Task.FromResult(GetFromProduct(product));
        }

        public override async Task GetProducts(Empty request, IServerStreamWriter<ProductModel> responseStream, ServerCallContext context)
        {
            foreach (var product in Mock.Data)
            {
                await responseStream.WriteAsync(GetFromProduct(product));
            }
        }

        public override Task<ProductModel> InsertProduct(InsertProductRequest request, ServerCallContext context)
        {
            var product = GetFromModel(request.Product);
            Mock.Data.Add(product);
            return Task.FromResult(GetFromProduct(product));
        }

        public override async Task<BulkInsertProductResponse> BulkInsertProduct(IAsyncStreamReader<ProductModel> requestStream, ServerCallContext context)
        {
            var inserted = 0;
            while (await requestStream.MoveNext())
            {
                var product = GetFromModel(requestStream.Current);
                Mock.Data.Add(product);
                inserted++;
            }
            return new BulkInsertProductResponse
            {
                Success = inserted > 0,
                Inserted = inserted
            };
        }

        public override Task<ProductModel> UpdateProduct(UpdateProductRequest request, ServerCallContext context)
        {
            var product = Mock.Data.FirstOrDefault(f => f.Id == request.Product.Id);
            if (product == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Product with Id: {product.Id} is not found."));
            }

            product.Name = request.Product.Name;
            product.Detail = request.Product.Detail;
            product.Price = request.Product.Price;
            product.Status = (ProductGrpc.Models.ProductStatus)request.Product.Status;
            product.CreatedOn = request.Product.CreatedOn.ToDateTime();

            return Task.FromResult(GetFromProduct(product));
        }

        public override Task<RemoveProductResponse> RemoveProduct(RemoveProductRequest request, ServerCallContext context)
        {
            var product = Mock.Data.FirstOrDefault(f => f.Id == request.Id);
            if (product == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Product with Id: {request.Id} is not found."));
            }

            Mock.Data.Remove(product);

            return Task.FromResult(new RemoveProductResponse { Success = true });
        }
    }
}