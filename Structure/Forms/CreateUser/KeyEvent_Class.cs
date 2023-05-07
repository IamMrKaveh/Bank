using System;
using System.Drawing;
using System.Windows.Forms;
using Bank.Structure.CheckInput;
using Bank.Structure.Encryption;
using Bank.Structure.Models;

namespace Bank.Structure.Forms.CreateUser
{
  public partial class CreateUser_Form
  {
    #region KeyPress Event

    private void UsernameInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      string username = Username_Textbox.Text.Trim();

      if (CheckUsernameInput.CheckUsername(e))
      {
        Username_StatusLabel.BackColor = Color.Red;
        e.Handled = true;
      }
      else if (CheckUserInput.Check_If_Empty(username))
      {
        Username_StatusLabel.BackColor = Color.Blue;
      }
      else if (username.Length < 4)
      {
        Username_StatusLabel.BackColor = Color.Red;
      }
      else
      {
        Username_StatusLabel.BackColor = Color.Green;
      }
    }

    private void PasswordInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      string password = Password_Textbox.Text.Trim();

      if (CheckPasswordInput.CheckPassword(e))
      {
        Password_StatusLabel.BackColor = Color.Red;
        e.Handled = true;
      }
      else if (CheckUserInput.Check_If_Empty(password))
      {
        Password_StatusLabel.BackColor = Color.Blue;
      }
      else if (password.Length < 4)
      {
        Password_StatusLabel.BackColor = Color.Red;
      }
      else
      {
        Password_StatusLabel.BackColor = Color.Green;
      }

      if (password.Length < 4)
      {
        Password_StatusLabel.BackColor = Color.Red;
      }
    }

    private void RePasswordInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      string rePassword = RePassword_Textbox.Text.Trim(),
        password = Password_Textbox.Text.Trim();

      if (CheckPasswordInput.CheckPassword(e))
      {
        RePassword_StatusLabel.BackColor = Color.Red;
        e.Handled = true;
      }
      else if (CheckUserInput.Check_If_Empty(rePassword))
      {
        RePassword_StatusLabel.BackColor = Color.Blue;
      }
      else if (rePassword.Length < 4 || password != rePassword)
      {
        RePassword_StatusLabel.BackColor = Color.Red;
      }
      else
      {
        RePassword_StatusLabel.BackColor = Color.Green;
      }
    }

    private void KeyAdminInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      string userKeyInput = KeyAdmin_Textbox.Text.Trim(), userKey = new MyEncryptor().EncryptionMin(userKeyInput);

      if (CheckUserInput.CheckString_Character(e) && CheckUserInput.CheckInt_Character(e))
      {
        KeyAdmin_StatusLabel.BackColor = Color.Red;
        e.Handled = true;
      }
      else if (CheckUserInput.Check_If_Empty(userKeyInput))
      {
        KeyAdmin_StatusLabel.BackColor = Color.Blue;
      }
      else if (userKey == User._keyAdmin)
      {
        KeyAdmin_StatusLabel.BackColor = Color.Green;
      }
      else
      {
        KeyAdmin_StatusLabel.BackColor = Color.Red;
      }
    }

    #endregion

    #region TextChanged Event

    private void Username_Textbox_TextChanged(object sender, EventArgs e)
    {
      string username = Username_Textbox.Text.Trim();

      if (CheckUserInput.Check_If_Empty(username))
      {
        Username_StatusLabel.BackColor = Color.Blue;
      }
      else if (username.Length < 4 || CheckUserInput.CheckFull(username))
      {
        Username_StatusLabel.BackColor = Color.Red;
      }
      else
      {
        Username_StatusLabel.BackColor = Color.Green;
      }
    }

    private void Password_Textbox_TextChanged(object sender, EventArgs e)
    {
      string password = Password_Textbox.Text.Trim();

      if (CheckUserInput.Check_If_Empty(password))
      {
        Password_StatusLabel.BackColor = Color.Blue;
      }
      else if (password.Length < 4 || CheckUserInput.CheckFull(password))
      {
        Password_StatusLabel.BackColor = Color.Red;
      }
      else
      {
        Password_StatusLabel.BackColor = Color.Green;
      }
    }

    private void RePassword_Textbox_TextChanged(object sender, EventArgs e)
    {
      string rePassword = RePassword_Textbox.Text.Trim(),
        password = Password_Textbox.Text.Trim();

      if (CheckUserInput.Check_If_Empty(rePassword))
      {
        RePassword_StatusLabel.BackColor = Color.Blue;
      }
      else if (rePassword.Length < 4 || CheckUserInput.CheckFull(rePassword) || password != rePassword)
      {
        RePassword_StatusLabel.BackColor = Color.Red;
      }
      else
      {
        RePassword_StatusLabel.BackColor = Color.Green;
      }
    }

    private void KeyAdmin_Textbox_TextChanged(object sender, EventArgs e)
    {
      string userKeyInput = KeyAdmin_Textbox.Text.Trim(),
        userkey = new MyEncryptor().EncryptionMin(userKeyInput);

      if (CheckUserInput.Check_If_Empty(userKeyInput))
      {
        KeyAdmin_StatusLabel.BackColor = Color.Blue;
      }
      else if (userKeyInput.Length < 4 || CheckUserInput.CheckFull(userKeyInput) || userkey != User._keyAdmin)
      {
        KeyAdmin_StatusLabel.BackColor = Color.Red;
      }
      else
      {
        KeyAdmin_StatusLabel.BackColor = Color.Green;
      }
    }

    #endregion

    #region KeyUp

    private void Username_Textbox_KeyUp(object sender, KeyEventArgs e)
      => Username_Textbox_TextChanged(null, null);

    private void Password_Textbox_KeyUp(object sender, KeyEventArgs e)
      => Password_Textbox_TextChanged(null, null);

    private void RePassword_Textbox_KeyUp(object sender, KeyEventArgs e)
      => RePassword_Textbox_TextChanged(null, null);

    private void KeyAdmin_Textbox_KeyUp(object sender, KeyEventArgs e)
      => KeyAdmin_Textbox_TextChanged(null, null);

    #endregion
  }
}
