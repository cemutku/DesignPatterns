using CommandPattern.Data;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class ChangeQuantityCommand : ICommand
    {
        private readonly Operation _operation;
        private readonly Product _product;
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IProductRepository _productRepository;

        public enum Operation
        {
            Increase,
            Decrease
        }

        public ChangeQuantityCommand(Operation operation,
            Product product,
            IShoppingCartRepository shoppingCartRepository,
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _shoppingCartRepository = shoppingCartRepository;
            _operation = operation;
            _product = product;
        }

        public bool CanExecute()
        {
            switch (_operation)
            {
                case Operation.Increase:
                    return _shoppingCartRepository.Get(_product.Id).Quantity != 0;
                case Operation.Decrease:
                    return (_productRepository.GetStock(_product.Id) - 1) >= 0;
            }

            return false;
        }

        public void Execute()
        {
            switch (_operation)
            {
                case Operation.Increase:
                    _productRepository.DecreaseStock(_product, 1);
                    _shoppingCartRepository.IncreaseQuantity(_product);
                    break;
                case Operation.Decrease:
                    _productRepository.IncreaseStock(_product, 1);
                    _shoppingCartRepository.DecreaseQuantity(_product);
                    break;
                default:
                    break;
            }
        }

        public void Undo()
        {
            switch (_operation)
            {
                case Operation.Increase:
                    _productRepository.IncreaseStock(_product, 1);
                    _shoppingCartRepository.DecreaseQuantity(_product);
                    break;
                case Operation.Decrease:
                    _productRepository.DecreaseStock(_product, 1);
                    _shoppingCartRepository.IncreaseQuantity(_product);
                    break;
                default:
                    break;
            }
        }
    }
}
