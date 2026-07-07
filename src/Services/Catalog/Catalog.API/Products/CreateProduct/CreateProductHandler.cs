using BuildingBlocks.CQRS;
using Catalog.API.Models;

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
    decimal Price) : ICommand<CreateProductResult>;

/// <summary>
/// CreateProductResult represents a response/return object which in this case only returns a product id.
/// </summary>
/// <param name="Id"></param>
public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler : 
    ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(
        CreateProductCommand command, 
        CancellationToken cancellationToken)
    {

        //Create Product entity from the command object
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        //TODO:Save to database

        //return CreateProductResult
        return new CreateProductResult(Guid.NewGuid());
    }
}
