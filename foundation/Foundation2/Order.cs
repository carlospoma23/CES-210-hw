public class Order
{

    private List<Product> _product; //= new List<Product>();

    private Customer _customer;


    public Order(Customer customer)
    {
        _product = new List<Product>();
        _customer = customer;

    }

    public void AddProduct(Product product)
    {

        _product.Add(product);

    }

    public decimal GetTotalPrice()
    {
        decimal _totalCost = 0;

        foreach (Product product in _product)

        {
            _totalCost += product.GetTotalCost();
        }

        decimal _shippingCost;
        if (_customer.LivesInUSA())
        {
            _shippingCost = 5.00m;

        }
        else
        {

            _shippingCost = 35.00m;
        }

        return _totalCost + _shippingCost;

    }


    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _product)
        {

            label += "Producto: " + product.GetName() + " (ID: " + product.GetProductId() + ")\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }



}