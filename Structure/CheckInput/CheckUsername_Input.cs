using System.Windows.Forms;

namespace Bank.Structure.CheckInput
{
    public static class CheckUsernameInput
    {
        public static bool CheckUsername(KeyPressEventArgs e) =>
            CheckUserInput.CheckInt(e) && CheckUserInput.CheckString(e) && (e.KeyChar != '_');
    }
}
