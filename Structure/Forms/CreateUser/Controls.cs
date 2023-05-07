using System.Drawing;
using Bank.Structure.Message;

namespace Bank.Structure.Forms.CreateUser
{
  public partial class CreateUser_Form
  {
    private void Clean()
    {
      ClearTextbox();

      ChangeBackColor_ToBlue();

      IsAdmin_Checkbox.Checked = false;
    }

    private void ClearTextbox()
    {
      Username_Textbox.Text =
        Password_Textbox.Text =
          RePassword_Textbox.Text =
            KeyAdmin_Textbox.Text = string.Empty;
    }

    private void ChangeBackColor_ToBlue()
    {
      Username_StatusLabel.BackColor =
        Password_StatusLabel.BackColor =
          RePassword_StatusLabel.BackColor =
            KeyAdmin_StatusLabel.BackColor = Color.Blue;
    }
  }
}
