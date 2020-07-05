using CommandPattern.Data;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class AddToCartCommand : ICommand
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IProductRepository _productRepository;
        private readonly Product _product;

        public AddToCartCommand(IShoppingCartRepository shoppingCartRepository,
            IProductRepository productRepository,
            Product product)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _productRepository = productRepository;
            _product = product;
        }

        public bool CanExecute()
        {
            if (_product == null) return false;

            return _productRepository.GetStock(_product.Id) > 0;
        }

        public void Execute()
        {
            if (_product == null) return;
            _productRepository.DecreaseStock(_product, 1);
            _shoppingCartRepository.Add(_product);
        }

        public void Undo()
        {
            if (_product == null) return;

            var lineItem = _shoppingCartRepository.Get(_product.Id);
            _productRepository.IncreaseStock(_product, lineItem.Quantity);
            _shoppingCartRepository.RemoveAll(_product);
        }
    }
}
