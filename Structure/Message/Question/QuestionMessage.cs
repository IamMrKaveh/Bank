using System.Windows.Forms;

namespace Bank.Structure.Message
{
  public partial class MessageClass
  {
    public bool Question()
    {
      #region Yes/No

      DialogResult dialog = MessageBox.Show($"{_matn}",
        $"{_caption}",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2);

      return dialog == DialogResult.Yes;

      #endregion Yes/No
    }
  }
}
