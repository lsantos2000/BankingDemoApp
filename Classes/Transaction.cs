namespace Classes;

public class Transaction
{
    public decimal Amount { get; } = 0;
    public DateTime Date { get; } = DateTime.Now;
    public string Notes { get; } = "";

    public Transaction(decimal amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }
}