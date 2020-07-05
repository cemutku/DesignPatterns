using CommandPattern.Commands;
using CommandPattern.Data;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command Pattern Example");

            var shoppingCartRepository = new ShoppingCartRepository();
            var productRepository = new ProductRepository();

            var product = productRepository.Find(1);

            var addToCartCommand = new AddToCartCommand(shoppingCartRepository,
                productRepository,
                product);

            var increaseQuantityCommand = new ChangeQuantityCommand(ChangeQuantityCommand.Operation.Increase,
                product,
                shoppingCartRepository,
                productRepository);

            var command = new Command();

            Console.WriteLine("Adding item to shopping cart...");
            command.Invoke(addToCartCommand);
            var addedLineItem = shoppingCartRepository.Get(product.Id);
            Console.WriteLine($"Item added to shopping cart : Name : {addedLineItem.Product.Name} Quantity : {addedLineItem.Quantity}");

            Console.WriteLine("Increasing quantity...");
            command.Invoke(increaseQuantityCommand);
            addedLineItem = shoppingCartRepository.Get(product.Id);
            Console.WriteLine($"Item added to shopping cart : Name : {addedLineItem.Product.Name} Quantity : {addedLineItem.Quantity}");

            Console.WriteLine("Increasing quantity...");
            command.Invoke(increaseQuantityCommand);
            addedLineItem = shoppingCartRepository.Get(product.Id);
            Console.WriteLine($"Item added to shopping cart : Name : {addedLineItem.Product.Name} Quantity : {addedLineItem.Quantity}");

            Console.WriteLine("Increasing quantity...");
            command.Invoke(increaseQuantityCommand);
            addedLineItem = shoppingCartRepository.Get(product.Id);
            Console.WriteLine($"Item added to shopping cart : Name : {addedLineItem.Product.Name} Quantity : {addedLineItem.Quantity}");

            PrintShoppingCart(shoppingCartRepository);

            Console.WriteLine("Undo all actions");
            command.Undo();

            PrintShoppingCart(shoppingCartRepository);
        }

        static void PrintShoppingCart(ShoppingCartRepository shoppingCartRepository)
        {
            decimal totalPrice = 0m;

            foreach (var lineItem in shoppingCartRepository.LineItems)
            {
                var price = lineItem.Value.Product.Price * lineItem.Value.Quantity;
                Console.WriteLine($"Product : {lineItem.Value.Product.Name} {lineItem.Value.Product.Price} X {lineItem.Value.Quantity} = {price}");
                totalPrice += price;
            }

            Console.WriteLine($"Total Price:\t{totalPrice}");
        }
    }
}
