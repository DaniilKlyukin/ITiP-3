using ProductsLibrary;

namespace ProductsWinFormsApp;

public class AppContext
{
    public static IList<Product> Products { get; } = new List<Product>();

    public static IList<Customer> Customers { get; } = new List<Customer>();

    public static IList<Order> Orders { get; } = new List<Order>();
}