namespace Models.TravelCard;

public class TravelCard
{
    private string _cardNumber;
    private decimal _balance;

    public string CardNumber => _cardNumber;
    public decimal Balance
    {
        get { return _balance; }
    }

    public TravelCard(string cardNumber, decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialBalance), "Balans manfiy bo'lmasligi kerak");
        }

        _cardNumber = cardNumber;
        _balance = initialBalance;
    }

    public bool TopUp(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            return true;
        }
        else
        {
            return false;            
        }

    }

    public bool Pay(decimal amount)
    {
        if (amount > 0 && HasEnoughBalance(amount))
        {
            _balance -= amount;
            return true;
        }
        else
            return false;
    }

    private bool HasEnoughBalance(decimal amount)
    {
        return _balance >= amount;
    }
}
