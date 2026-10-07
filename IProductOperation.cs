using productLinqAss.Model;

namespace produtLinqAss.Operation
{
    interface IProductOperation

    {
        int Add(Product product);
        List<Product> GetProducts();
        Product GetProductById(int id);//apply dto with projection quary

        List<Product> SearchByPrice(int price);
        Product UpdateProducts(Product product, int id);
        int DeleteProducts(int id);

    }
}