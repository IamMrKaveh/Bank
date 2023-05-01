using Bank.Structure.Encryption;

namespace Bank.Structure.Models
{
  internal class Users : IUsers
  {
    #region Properties

    #region Username

    public string EncryptedUsername
    {
      get => EncryptedUsername;
      set => EncryptedUsername = new MyEncryptor().EncryptionMin(value);
    }

    public string DecryptedUsername
    {
      get => DecryptedUsername;
      set => DecryptedUsername = new MyEncryptor().DecryptionMin(value);
    }

    #endregion

    #region Password

    public string EncryptedPassword
    {
      get => EncryptedPassword;
      set => EncryptedPassword = new MyEncryptor().EncryptionMin(value);
    }

    public string DecryptedPassword
    {
      get => DecryptedPassword;
      set => DecryptedPassword = new MyEncryptor().DecryptionMin(value);
    }

    #endregion

    public bool IsAdmin { get; set; }

    public static string _keyAdmin => new MyEncryptor().EncryptionMin("IamAdmin");

    #endregion
  }
}
