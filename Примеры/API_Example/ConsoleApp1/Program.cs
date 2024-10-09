using API_Example;

var purchaseManager = new PurchaseManager("purchases.json");

var customer1 = new Customer { Id = 1, Name = "John Doe", Email = "JD@gmail.com", Phone = "89115609524" };
var customer2 = new Customer { Id = 2, Name = "Bill White", Email = "white@gmail.com", Phone = "89557653322" };

var product1 = new Product { Id = 1, Name = "Слива", Price = 100, Description = "Лиловая, спелая, садовая" };
var product2 = new Product { Id = 2, Name = "Ваз 2107", Price = 1000, Description = "Не бита, не крашена" };

var purchase1 = new Purchase { Id = 1, Product = product1, Price = product1.Price, Amount = 3 };
var purchase2 = new Purchase { Id = 2, Product = product1, Price = product1.Price, Amount = 5 };
var purchase3 = new Purchase { Id = 3, Product = product2, Price = product2.Price, Amount = 1 };

var order1 = new Order { Id = 1, Customer = customer1, Purchases = new List<Purchase> { purchase1 } };
var order2 = new Order { Id = 2, Customer = customer2, Purchases = new List<Purchase> { purchase2, purchase3 } };

var payment1 = new Payment { Id = 1, Order = order1, Date = DateTime.Now, PaymentMethod = "Блокчейн транзакция" };
var payment2 = new Payment { Id = 2, Order = order2, Date = DateTime.Now.AddDays(-3), PaymentMethod = "Наличные" };

purchaseManager.AddOrder(order1);
purchaseManager.AddOrder(order2);
purchaseManager.AddPayment(payment1);
purchaseManager.AddPayment(payment2);

var customerId = 1;
// Получаем заказы покупателя
var orders = purchaseManager.GetOrdersByCustomer(customerId);
// Получаем оплаты покупателя
var payments = purchaseManager.GetPaymentsByCustomer(customerId);

// Выводим результаты
foreach (var order in orders)
{
    Console.WriteLine($"Заказ {order.Id} от {order.Customer.Name} на сумму {order.Total}");
}

foreach (var payment in payments)
{
    Console.WriteLine($"Платеж {payment.Id} за заказ {payment.Order.Id} на сумму {payment.Order.Total}");
}