using AdapterPattern.Adapters;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ProductFileSourceAdapter

            string fileName = "products.json";

            var fileService = new ProductService(
                new ProductFileSourceAdapter(fileName, new ProductFileSource()));

            var fileResult = fileService.ListProducts();

            Console.WriteLine(fileResult);

            #endregion

            #region ProductApiSourceAdapter

            var apiService = new ProductService(
                new ProductApiSourceAdapter(new ProductsApi()));

            var apiResult = apiService.ListProducts();

            Console.WriteLine(apiResult);

            #endregion
        }
    }
}
