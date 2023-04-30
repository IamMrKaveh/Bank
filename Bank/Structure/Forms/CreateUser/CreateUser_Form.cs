using System;
using System.Drawing;
using System.Windows.Forms;
using Bank.Structure.CheckInput;
using Bank.Structure.Encryption;
using Bank.Structure.Models;

namespace Bank.Structure.Forms.CreateUser
{
  public partial class CreateUser_Form : Form
  {
    public CreateUser_Form()
    {
      InitializeComponent();
    }

    private void CreateUser_Button_Click(object sender, EventArgs e)
    {
      //check if empty => check if true => add user
    }

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
      else
      {
        Username_StatusLabel.BackColor = Color.Green;
      }
      
      if (username.Length < 4)
      {
        Username_StatusLabel.BackColor = Color.Red;
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
      string rePassword = RePassword_Textbox.Text.Trim();
      
      if (CheckPasswordInput.CheckPassword(e))
      {
        RePassword_StatusLabel.BackColor = Color.Red;
        e.Handled = true;
      }
      else if (CheckUserInput.Check_If_Empty(rePassword))
      {
        RePassword_StatusLabel.BackColor = Color.Blue;
      }
      else
      {
        RePassword_StatusLabel.BackColor = Color.Green;
      }

      if (rePassword.Length < 4)
      {
        RePassword_StatusLabel.BackColor = Color.Red;
      }
    }

    private void KeyAdminInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      string userKeyInput = KeyAdmin_Textbox.Text.Trim(), userKey = new MyEncryptor().EncryptionMin(userKeyInput);

      if (!(CheckUserInput.CheckString(e) || CheckUserInput.CheckInt(e)))
      {
        KeyAdmin_StatusLabel.BackColor = Color.Red;
        e.Handled = true;
      }
      else if (CheckUserInput.Check_If_Empty(userKeyInput))
      {
        KeyAdmin_StatusLabel.BackColor = Color.Blue;
      }
      else if (userKey == Users._keyAdmin)
      {
        KeyAdmin_StatusLabel.BackColor = Color.Green;
      }
      else
      {
        KeyAdmin_StatusLabel.BackColor = Color.Red;
      }
    }

    #endregion
  }
}
