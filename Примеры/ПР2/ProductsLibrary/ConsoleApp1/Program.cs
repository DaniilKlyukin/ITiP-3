using ProductsLibrary;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Тестирование событий ===");

        // Создаем продукты
        Product product1 = new Product("P001", "Ноутбук", 799.99, 10);
        Product product2 = new Product("P002", "Смартфон", 499.99, 20);

        // Подписываемся на события Product
        product1.ProductStockAdded += ProductStockAddedHandler;
        product1.ProductStockRemoved += ProductStockRemovedHandler;
        product2.ProductStockAdded += ProductStockAddedHandler;
        product2.ProductStockRemoved += ProductStockRemovedHandler;

        Console.WriteLine("\n=== Тестирование событий Product ===");
        product1.AddStock(5); // Должно вызвать ProductStockAdded
        product1.RemoveStock(3); // Должно вызвать ProductStockRemoved
        product1.RemoveStock(20); // Должно вызвать ProductStockRemoved (но не удастся)

        // Создаем клиента
        Customer customer = new Customer("C001", "Иван Иванов", "ivan@example.com", "Москва, ул. Пушкина, д. 1");

        // Подписываемся на события Customer
        customer.CustomerAddedOrder += CustomerAddedOrderHandler;

        // Создаем заказ
        Order order = new Order("O001", customer);

        // Подписываемся на события Order
        order.ProductAddedToOrder += ProductAddedToOrderHandler;
        order.OrderStatusUpdated += OrderStatusUpdatedHandler;

        Console.WriteLine("\n=== Тестирование событий Order ===");
        // Добавляем продукты в заказ
        if (order.AddProduct(product1)) // Должно вызвать ProductAddedToOrder и ProductStockRemoved
        {
            Console.WriteLine($"Продукт '{product1.Name}' добавлен в заказ.");
        }

        if (order.AddProduct(product2)) // Должно вызвать ProductAddedToOrder и ProductStockRemoved
        {
            Console.WriteLine($"Продукт '{product2.Name}' добавлен в заказ.");
        }

        // Обновляем статус заказа (должно вызвать OrderStatusUpdated)
        order.UpdateStatus(OrderStatus.Shipped);

        Console.WriteLine("\n=== Тестирование событий Customer ===");
        // Добавляем заказ к клиенту (должно вызвать CustomerAddedOrder)
        customer.AddOrder(order);

        // Выводим информацию
        Console.WriteLine("\n=== Итоговая информация ===");
        Console.WriteLine(customer.GetCustomerInfo());
        Console.WriteLine($"У клиента заказы: {customer.HasOrders()}");
        Console.WriteLine(order.GetOrderSummary());
    }

    // Обработчики событий
    private static void ProductStockAddedHandler(object sender, ProductStockAddedEventArgs args)
    {
        var product = (Product)sender;
        Console.WriteLine($"[Событие] Количество товара '{product.Name}' увеличено на {args.Quantity}. Новый остаток: {product.StockQuantity}");
    }

    private static void ProductStockRemovedHandler(object sender, ProductStockRemovedEventArgs args)
    {
        var product = (Product)sender;
        if (product.StockQuantity >= args.Quantity)
        {
            Console.WriteLine($"[Событие] Количество товара '{product.Name}' уменьшено на {args.Quantity}. Новый остаток: {product.StockQuantity}");
        }
        else
        {
            Console.WriteLine($"[Событие] Попытка уменьшить количество товара '{product.Name}' на {args.Quantity}, но недостаточно на складе (остаток: {product.StockQuantity})");
        }
    }

    private static void ProductAddedToOrderHandler(object sender, ProductAddedToOrderEventArgs args)
    {
        var order = (Order)sender;
        Console.WriteLine($"[Событие] Продукт '{args.Product.Name}' добавлен в заказ {order.OrderID}");
    }

    private static void OrderStatusUpdatedHandler(object sender, OrderStatusUpdatedEventArgs args)
    {
        var order = (Order)sender;
        Console.WriteLine($"[Событие] Статус заказа {order.OrderID} изменен: {args.Old} -> {args.New}");
    }

    private static void CustomerAddedOrderHandler(object sender, CustomerAddedOrderEventArgs args)
    {
        var customer = (Customer)sender;
        Console.WriteLine($"[Событие] Клиент {customer.Name} добавил новый заказ {args.Order.OrderID}");
    }
}