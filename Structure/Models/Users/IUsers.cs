namespace Bank.Structure.Models
{
  public interface IUsers
  {
    string EncryptedUsername { get; set; }
    
    string DecryptedUsername { get; set; }

    string EncryptedPassword { get; set; }
    
    string DecryptedPassword { get; set; }

    bool IsAdmin { get; set; }
  }
}
