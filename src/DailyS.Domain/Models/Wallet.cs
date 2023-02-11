namespace DailyS.Domain.Models;

public class Wallet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; set; }

    // public int UserId { get; set; }
    // public User User { get; set; }

    // public ICollection<WalletTransaction> WalletTransactions { get; set; }
}
