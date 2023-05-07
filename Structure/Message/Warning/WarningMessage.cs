using System.Windows.Forms;

namespace Bank.Structure.Message
{
  public partial class MessageClass
  {
    public bool Warning()
    {
      if (_yes_no)
      {
        #region Yes/No Keys

        DialogResult dialogResult = MessageBox.Show($"{_matn}",
          $"{_caption}",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning,
          MessageBoxDefaultButton.Button2);

        return dialogResult == DialogResult.Yes;

        #endregion Yes/No Keys
      }
      else
      {
        #region OK Keys

        MessageBox.Show($"{_matn}",
          $"{_caption}",
          MessageBoxButtons.OK,
          MessageBoxIcon.Warning);
        return false;

        #endregion OK Keys
      }
    }
  }
}
