namespace ProductsLibrary;

public record ProductStockAddedEventArgs(int Quantity);
public delegate void ProductStockAdded(object sender, ProductStockAddedEventArgs args);

public record ProductStockRemovedEventArgs(int Quantity);
public delegate void ProductStockRemoved(object sender, ProductStockRemovedEventArgs args);

// Класс для представления продукта
public class Product : ICloneable, IEquatable<Product>
{
    public event ProductStockAdded? ProductStockAdded;
    public event ProductStockRemoved? ProductStockRemoved;

    public string ProductID { get; private set; }
    public string Name { get; private set; }
    public double Price { get; private set; }
    public int StockQuantity { get; private set; }

    public Product(string productId, string name, double price, int stockQuantity)
    {
        ProductID = productId;
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public void AddStock(int quantity)
    {
        StockQuantity += quantity;
        ProductStockAdded?.Invoke(this, new ProductStockAddedEventArgs(quantity));
    }

    public bool RemoveStock(int quantity)
    {
        if (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
            ProductStockRemoved?.Invoke(this, new ProductStockRemovedEventArgs(quantity));
            return true;
        }
        else
        {
            ProductStockRemoved?.Invoke(this, new ProductStockRemovedEventArgs(quantity));
            return false;
        }
    }

    public double CalculateTotalPrice(int quantity)
    {
        return Price * quantity;
    }

    public string GetProductSummary()
    {
        return $"{Name} (ID: {ProductID}) - Цена: {Price}, Остаток: {StockQuantity}";
    }

    public override string ToString()
    {
        return GetProductSummary();
    }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public bool Equals(Product? other)
    {
        if (other == null)
            return false;

        return other.ProductID == ProductID;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Product);
    }

    public override int GetHashCode()
    {
        return ProductID.GetHashCode();
    }
}
