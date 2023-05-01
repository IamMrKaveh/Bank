using System.Windows.Forms;

namespace Bank.Structure.CheckInput
{
    public static class CheckUsernameInput
    {
        public static bool CheckUsername(KeyPressEventArgs e) =>
            CheckUserInput.CheckInt_Character(e) && CheckUserInput.CheckString_Character(e) && (e.KeyChar != '_');
    }
}
