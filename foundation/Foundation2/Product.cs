public class Products
{
    private string _productName;
    private int _productID;
    private decimal _productPrice;
    private int _quantity;

    public Products(string name, int id, decimal price, int quantity)
    {
        _productName = name;   // Instaciar la variables declaradas
        _productID = id;
        _productPrice = price;
        _quantity = quantity;
    }
    
    /*public string GetName() => _productName;
    public int GetProductId() => _productID;
    public decimal GetPrice() => _productPrice;
    public int GetQuantity() => _quantity;*/
    
    // Método convencional para obtener el nombre del producto
    public string GetName() 
    { 
        return _productName; 
    }

    // Método convencional para obtener el ID del producto
    public int GetProductId() 
    { 
        return _productID; 
    }

    // Método convencional para obtener el precio del producto
    public decimal GetPrice() 
    { 
        return _productPrice; 
    }

    // Método convencional para obtener la cantidad del producto
    public int GetQuantity() 
    { 
        return _quantity; 
    }


    public decimal GetTotalCost()
    {
        return _productPrice * _quantity;
    }

}