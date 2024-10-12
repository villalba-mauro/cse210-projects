using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private Customer _customer; //para llamar una clase, primero va el tipo de dato (nombre de la CLASE) y luego el nombre de la variable para acceder a sus metodos y propiedades
    private List<Products> _products = new List<Products>();

    public Order(Customer customer, List<Products> products)
    {
        _customer = customer;
        _products = products;
    }

    
    public decimal totalPrice()
    {
        decimal totalProductCost = 0;

        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost(); 
        }
        
        decimal shippingCost = _customer.isInUsa() ? 5m : 35m; // If the customer is from USA the shipping cost is 5 and if the customer is from other country shipping cost is 35

        return totalProductCost + shippingCost;
    }

    public string packingLabel()
    {
        string label = "Packing Label: \n";

        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()}) - Price: {product.GetPrice()}\n" ;
        }
        return label;
    }

    public string shippingLabel()
    {
        _customer.CustomerName();
        _customer.GetfullAdress();
        string _nombre = _customer.CustomerName();
        string _direccion = _customer.GetfullAdress();

        string fullLabel = $"Shipping Label: {_nombre}, {_direccion}";
        return fullLabel;

    }
}

