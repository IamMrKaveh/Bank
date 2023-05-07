namespace Bank.Structure.Models
{
  public interface IUsers
  {
    bool Create();

    bool Read();

    bool Update();
    
    bool Delete();
  }

  public interface IEncrypted
  {
    string EncryptedUsername { get; set; }
    string EncryptedPassword { get; set; }
  }

  public interface IDecrypted
  {
    string DecryptedUsername { get; set; }

    string DecryptedPassword { get; set; }
  }
}
