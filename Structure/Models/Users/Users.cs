using Bank.Structure.Encryption;
using Bank.Structure.Database.Users;
using Bank.Structure.Message;

namespace Bank.Structure.Models
{
  public class User : IUsers
  {
    #region Properties

    private readonly EncryptedUsers _encryptedUser;

    private readonly DecryptedUsers _decryptedUser;

    public static string _keyAdmin => new MyEncryptor().EncryptionMin("IamAdmin");

    #endregion

    #region Constructors and Destructors

    public User(EncryptedUsers encryptedUser = null, DecryptedUsers decryptedUser = null)
    {
      _encryptedUser = encryptedUser;
      _decryptedUser = decryptedUser;
    }

    #endregion

    public bool Create() => new UserTable().AddUser(_encryptedUser) == "success";

    public bool Read()
    {
      throw new System.NotImplementedException();
    }

    public bool Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }

  public class EncryptedUsers : IEncrypted
  {
    private string _encryptedUsername;

    public string EncryptedUsername
    {
      get => _encryptedUsername;
      set => _encryptedUsername = new MyEncryptor().EncryptionMin(value);
    }

    private string _encryptedPassword;

    public string EncryptedPassword
    {
      get => _encryptedPassword;
      set => _encryptedPassword = new MyEncryptor().EncryptionMin(value);
    }
  }

  public class DecryptedUsers : IDecrypted
  {
    public string DecryptedUsername
    {
      get => DecryptedUsername;
      set => DecryptedUsername = new MyEncryptor().DecryptionMin(value);
    }

    public string DecryptedPassword
    {
      get => DecryptedPassword;
      set => DecryptedPassword = new MyEncryptor().DecryptionMin(value);
    }
  }
}
