using MediatR;

namespace Catalog.API.Products.CreateProduct;

/// <summary>
/// CreateProductCommand represents the data that we need to create a new product
/// </summary>
/// <param name="Name">The name of the product</param>
/// <param name="Category">The categories the product belongs to</param>
/// <param name="Description">The description of the product</param>
/// <param name="ImageFile">The image file of the product</param>
/// <param name="Price">The price of the product</param>
public record CreateProductCommand(
    string Name,
    List<string> Category,
    string Description,
    string ImageFile,
    decimal Price) : IRequest<CreateProductResult>;

/// <summary>
/// CreateProductResult represents a response/return object which in this case only returns a product id.
/// </summary>
/// <param name="Id"></param>
public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(
        CreateProductCommand request, 
        CancellationToken cancellationToken)
    {
        //Business logic to create a product
        throw new NotImplementedException();
    }
}
