using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bank.Structure.CheckInput
{
  internal static class EmailInput
  {
    public static bool EmailCharacter_IsMatch(KeyPressEventArgs e)
    {
      return CheckUserInput.CheckInt(e) && CheckUserInput.CheckString(e)
                                        && (e.KeyChar != '@')
                                        && (e.KeyChar != '.')
                                        && (e.KeyChar != '_');
    }

    public static bool EmailIsMatch(string email)
    {
      return new Regex
        ("^[a-zA-Z]+[a-zA-Z0-9]+[[a-zA-Z0-9-_.!#$%'*+/=?^]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$").IsMatch(email);
    }
  }
}
