using System.Windows.Forms;

namespace Bank.Structure.CheckInput
{
    internal static class CheckPasswordInput
    {
        public static bool CheckPassword(KeyPressEventArgs e)
            => CheckUsernameInput.CheckUsername(e);
    }
}
