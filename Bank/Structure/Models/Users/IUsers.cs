namespace Bank.Structure.Models
{
  public interface IUsers
  {
    string EncryptedUsername { get; set; }

    string EncryptedPassword { get; set; }

    bool IsAdmin { get; set; }
  }
}
