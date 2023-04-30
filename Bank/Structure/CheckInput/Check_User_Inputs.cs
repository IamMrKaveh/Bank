using System;
using System.Linq;
using System.Windows.Forms;

namespace Bank.Structure.CheckInput
{
    internal static class CheckUserInput
    {
        public static bool CheckInt(KeyPressEventArgs e)
            => (e.KeyChar != Convert.ToChar(8)) && (e.KeyChar < '0' || e.KeyChar > '9');

        public static bool CheckString(KeyPressEventArgs e)
            => (e.KeyChar != Convert.ToChar(8)) && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z');

        public static bool Check_If_Empty(params string[] array)
        {
            bool flag = false;
            foreach (var _ in array
                         .Where(item => string.IsNullOrWhiteSpace(item))
                         .Select(item => new { })
                     )
            {
                flag = true;
            }

            return flag;
        }
    }
}
