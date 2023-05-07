using System.Windows.Forms;

namespace Bank.Structure.Message
{
  public partial class MessageClass
  {
    public bool Error()
    {
      if (_yes_no)
      {
        #region Yes/No Keys

        DialogResult dialogResult = MessageBox.Show($"{_matn}",
          $"{_caption}",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Error,
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
          MessageBoxIcon.Error);
        return false;

        #endregion OK Keys
      }
    }
  }
}
