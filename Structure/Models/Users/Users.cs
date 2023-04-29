using Bank.Structure.Encryption;

namespace Bank.Structure.Models
{
  internal class Users : IUsers
  {
    #region Properties

    #region Username

    public string EncryptedUsername
    {
      get { return EncryptedUsername; }
      set { EncryptedUsername = new MyEncryptor().EncryptionMin(value); }
    }

    #endregion

    #region Password

    public string EncryptedPassword
    {
      get { return EncryptedPassword; }
      set { EncryptedPassword = new MyEncryptor().EncryptionMin(value); }
    }

    #endregion

    public bool IsAdmin { get; set; }

    private readonly string _keyAdmin = new MyEncryptor().EncryptionMin("IamAdmin");

    #endregion
  }
}
