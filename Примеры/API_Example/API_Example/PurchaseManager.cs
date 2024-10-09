using Newtonsoft.Json;

namespace API_Example
{
    public class PurchaseManager
    {
        private List<Order> orders;
        private List<Payment> payments;
        private string filePath;

        public PurchaseManager(string filePath)
        {
            this.filePath = filePath;
            this.orders = new List<Order>();
            this.payments = new List<Payment>();
            LoadData();
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
            SaveData();
        }

        public void RemoveOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                orders.Remove(order);
                SaveData();
            }
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public void AddPayment(Payment payment)
        {
            payments.Add(payment);
            SaveData();
        }

        public void RemovePayment(int id)
        {
            var payment = payments.FirstOrDefault(p => p.Id == id);
            if (payment != null)
            {
                payments.Remove(payment);
                SaveData();
            }
        }

        public List<Payment> GetPayments()
        {
            return payments;
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                var jsonData = File.ReadAllText(filePath);
                var data = JsonConvert.DeserializeObject<PurchaseData>(jsonData);
                orders = data.Orders;
                payments = data.Payments;
            }
        }

        private void SaveData()
        {
            var data = new PurchaseData
            {
                Orders = orders,
                Payments = payments
            };
            var jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        private class PurchaseData
        {
            public List<Order> Orders { get; set; }
            public List<Payment> Payments { get; set; }
        }

        public List<Order> GetOrdersByCustomer(int customerId)
        {
            return orders.Where(o => o.Customer.Id == customerId).ToList();
        }

        public List<Payment> GetPaymentsByCustomer(int customerId)
        {
            return payments.Where(p => p.Order.Customer.Id == customerId).ToList();
        }
    }
}
