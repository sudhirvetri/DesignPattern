using System;

public interface IPaymentStragery
{
    void pay(int amount);
}

public class CreditCardPayment:IPaymentStragery
{
    public void pay(int amount)
    {
        Console.WriteLine($"Paid ${amount} with CreditCard");
    }
}
public class PayPalPayment:IPaymentStragery
{
    public void pay(int amount)
    {
        Console.WriteLine($"Paid ${amount} with PayPal");
    }
}
public class UPIPayment:IPaymentStragery
{
    public void pay(int amount)
    {
        Console.WriteLine($"Paid ${amount} with UPI");
    }
}
public class InternetBankingPayment:IPaymentStragery
{
    public void pay(int amount)
    {
        Console.WriteLine($"Paid ${amount} with InternetBanking");
    }
}

public class ShoppingCart
{
    private IPaymentStragery _paymentStragery;
    
    public void setPaymentStrategy(IPaymentStragery paymentStragery)
    {
        this._paymentStragery = paymentStragery;
    }
    
    
    public void Checkout(int amount)
    {
        if(_paymentStragery==null)
        {
            Console.WriteLine("Please choose a payment Strategy");
        }
        
        _paymentStragery.pay(amount);
    }
}


class Program {
  static void Main() {
    
      ShoppingCart cart = new ShoppingCart();
      cart.setPaymentStrategy(new InternetBankingPayment());
      cart.Checkout(10);
      
      cart.setPaymentStrategy(new CreditCardPayment());
      cart.Checkout(10);
      
      cart.setPaymentStrategy(new PayPalPayment());
      cart.Checkout(10);
      
    
  }
}
