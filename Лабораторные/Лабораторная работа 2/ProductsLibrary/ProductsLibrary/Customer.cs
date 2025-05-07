namespace ProductsLibrary;

public record CustomerAddedOrderEventArgs(Order Order);
public delegate void CustomerAddedOrder(object sender, CustomerAddedOrderEventArgs args);

// Класс для представления клиента
public class Customer : ICloneable, IEquatable<Customer>
{
    public event CustomerAddedOrder? CustomerAddedOrder;

    public string CustomerID { get; private set; }
    public string Name { get; private set; }

    public IReadOnlyList<Order> Orders => orders.AsReadOnly();

    private string email;
    private string address;
    private List<Order> orders;

    public Customer(string customerId, string name, string email, string address)
    {
        CustomerID = customerId;
        Name = name;
        SetEmail(email);
        SetAddress(address);
        orders = new List<Order>();
    }

    public void SetEmail(string newEmail)
    {
        if (IsValidEmail(newEmail))
        {
            email = newEmail;
        }
        else
        {
            throw new ArgumentException("Неверный формат электронной почты.");
        }
    }

    public void SetAddress(string newAddress)
    {
        if (IsValidAddress(newAddress))
        {
            address = newAddress;
        }
        else
        {
            throw new ArgumentException("Неверный формат адреса.");
        }
    }

    public string GetCustomerInfo()
    {
        return $"Клиент: {Name} (ID: {CustomerID}), Email: {email}, Адрес: {address}";
    }

    public override string ToString()
    {
        return GetCustomerInfo();
    }

    public bool HasOrders()
    {
        return orders.Count > 0; // Проверка на наличие заказов
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
        CustomerAddedOrder?.Invoke(this, new CustomerAddedOrderEventArgs(order));
    }

    public void AddOrders(IEnumerable<Order> orders)
    {
        foreach (var order in orders)
        {
            AddOrder(order);
        }
    }

    private bool IsValidEmail(string email)
    {
        // Проверка на наличие символа "@" и точки "."
        return email.Contains("@") && email.IndexOf('.') > email.IndexOf('@') + 1;
    }

    private bool IsValidAddress(string address)
    {
        // Проверка, что адрес не пустой и содержит хотя бы 5 символов
        return !string.IsNullOrWhiteSpace(address) && address.Length >= 5;
    }

    public object Clone()
    {
        var customer = new Customer(CustomerID, Name, email, address);

        var orders = new List<Order>();

        foreach (var order in Orders)
        {
            customer.AddOrder((Order)order.Clone());
        }

        return customer;
    }

    public bool Equals(Customer? other)
    {
        if (other == null)
            return false;

        return other.CustomerID == CustomerID;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Customer);
    }

    public override int GetHashCode()
    {
        return CustomerID.GetHashCode();
    }
}
