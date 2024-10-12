public class Customer
{
    private string _customerName;
    private Adress _customerAdress;

    public  Customer(string Name, Adress adress){
        _customerName = Name;
        _customerAdress = adress;
    }

    public string CustomerName()=> _customerName;
    public string GetfullAdress()
    {
        return _customerAdress.fullAdress();
    }
    
    public bool isInUsa()
    {
      return _customerAdress.isInUsa();
    }

}