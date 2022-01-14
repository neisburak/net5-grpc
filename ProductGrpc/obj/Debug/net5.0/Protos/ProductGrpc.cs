// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/product.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ProductGrpc.Protos {
  /// <summary>
  /// servis sözleşmesi
  /// </summary>
  public static partial class ProductProtoService
  {
    static readonly string __ServiceName = "products.ProductProtoService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGrpc.Protos.GetProductRequest> __Marshaller_products_GetProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGrpc.Protos.GetProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGrpc.Protos.ProductModel> __Marshaller_products_ProductModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGrpc.Protos.ProductModel.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGrpc.Protos.InsertProductRequest> __Marshaller_products_InsertProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGrpc.Protos.InsertProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGrpc.Protos.BulkInsertProductResponse> __Marshaller_products_BulkInsertProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGrpc.Protos.BulkInsertProductResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGrpc.Protos.UpdateProductRequest> __Marshaller_products_UpdateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGrpc.Protos.UpdateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGrpc.Protos.RemoveProductRequest> __Marshaller_products_RemoveProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGrpc.Protos.RemoveProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGrpc.Protos.RemoveProductResponse> __Marshaller_products_RemoveProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGrpc.Protos.RemoveProductResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGrpc.Protos.GetProductRequest, global::ProductGrpc.Protos.ProductModel> __Method_GetProduct = new grpc::Method<global::ProductGrpc.Protos.GetProductRequest, global::ProductGrpc.Protos.ProductModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProduct",
        __Marshaller_products_GetProductRequest,
        __Marshaller_products_ProductModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::ProductGrpc.Protos.ProductModel> __Method_GetProducts = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::ProductGrpc.Protos.ProductModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetProducts",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_products_ProductModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGrpc.Protos.InsertProductRequest, global::ProductGrpc.Protos.ProductModel> __Method_InsertProduct = new grpc::Method<global::ProductGrpc.Protos.InsertProductRequest, global::ProductGrpc.Protos.ProductModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InsertProduct",
        __Marshaller_products_InsertProductRequest,
        __Marshaller_products_ProductModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGrpc.Protos.ProductModel, global::ProductGrpc.Protos.BulkInsertProductResponse> __Method_BulkInsertProduct = new grpc::Method<global::ProductGrpc.Protos.ProductModel, global::ProductGrpc.Protos.BulkInsertProductResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "BulkInsertProduct",
        __Marshaller_products_ProductModel,
        __Marshaller_products_BulkInsertProductResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGrpc.Protos.UpdateProductRequest, global::ProductGrpc.Protos.ProductModel> __Method_UpdateProduct = new grpc::Method<global::ProductGrpc.Protos.UpdateProductRequest, global::ProductGrpc.Protos.ProductModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProduct",
        __Marshaller_products_UpdateProductRequest,
        __Marshaller_products_ProductModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGrpc.Protos.RemoveProductRequest, global::ProductGrpc.Protos.RemoveProductResponse> __Method_RemoveProduct = new grpc::Method<global::ProductGrpc.Protos.RemoveProductRequest, global::ProductGrpc.Protos.RemoveProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveProduct",
        __Marshaller_products_RemoveProductRequest,
        __Marshaller_products_RemoveProductResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ProductGrpc.Protos.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductProtoService</summary>
    [grpc::BindServiceMethod(typeof(ProductProtoService), "BindService")]
    public abstract partial class ProductProtoServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGrpc.Protos.ProductModel> GetProduct(global::ProductGrpc.Protos.GetProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetProducts(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::ProductGrpc.Protos.ProductModel> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGrpc.Protos.ProductModel> InsertProduct(global::ProductGrpc.Protos.InsertProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGrpc.Protos.BulkInsertProductResponse> BulkInsertProduct(grpc::IAsyncStreamReader<global::ProductGrpc.Protos.ProductModel> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGrpc.Protos.ProductModel> UpdateProduct(global::ProductGrpc.Protos.UpdateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGrpc.Protos.RemoveProductResponse> RemoveProduct(global::ProductGrpc.Protos.RemoveProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductProtoServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetProduct, serviceImpl.GetProduct)
          .AddMethod(__Method_GetProducts, serviceImpl.GetProducts)
          .AddMethod(__Method_InsertProduct, serviceImpl.InsertProduct)
          .AddMethod(__Method_BulkInsertProduct, serviceImpl.BulkInsertProduct)
          .AddMethod(__Method_UpdateProduct, serviceImpl.UpdateProduct)
          .AddMethod(__Method_RemoveProduct, serviceImpl.RemoveProduct).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductProtoServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductGrpc.Protos.GetProductRequest, global::ProductGrpc.Protos.ProductModel>(serviceImpl.GetProduct));
      serviceBinder.AddMethod(__Method_GetProducts, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::ProductGrpc.Protos.ProductModel>(serviceImpl.GetProducts));
      serviceBinder.AddMethod(__Method_InsertProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductGrpc.Protos.InsertProductRequest, global::ProductGrpc.Protos.ProductModel>(serviceImpl.InsertProduct));
      serviceBinder.AddMethod(__Method_BulkInsertProduct, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::ProductGrpc.Protos.ProductModel, global::ProductGrpc.Protos.BulkInsertProductResponse>(serviceImpl.BulkInsertProduct));
      serviceBinder.AddMethod(__Method_UpdateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductGrpc.Protos.UpdateProductRequest, global::ProductGrpc.Protos.ProductModel>(serviceImpl.UpdateProduct));
      serviceBinder.AddMethod(__Method_RemoveProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductGrpc.Protos.RemoveProductRequest, global::ProductGrpc.Protos.RemoveProductResponse>(serviceImpl.RemoveProduct));
    }

  }
}
#endregion
