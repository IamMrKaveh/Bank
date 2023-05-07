using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Structure.Message;
using Bank.Structure.Models;

namespace Bank.Structure.Forms.CreateUser
{
  public partial class CreateUser_Form : Form
  {
    public CreateUser_Form()
    {
      InitializeComponent();
    }

    private async void CreateUser_Button_Click(object sender, EventArgs e)
    {
      if (ButtonsAreGreen())
      {
        if (UserCommit())
        {
          if (IsUserAdmin())
          {
            if (KeyAdmin_StatusLabel.BackColor == Color.Green)
            {
              if (true)//check if admin already exists in the database
              {
                AddAdmin_TO_Databse();
              }
              else
              {
                
              }
            }
            else
            {
              new MessageClass().IncorrectInformation();
            }
          }
          else
          {
            if (true)//check if user is already exist in database
            {
              AddUser_TO_Databse();
            }
            else
            {
              
            }
          }
        }
        else
        {
          new MessageClass().MissionStopped();
        }
      }
      else
      {
        new MessageClass().IncorrectInformation();
      }
    }

    private bool ButtonsAreGreen() => Username_StatusLabel.BackColor == Color.Green
                                      && Password_StatusLabel.BackColor == Color.Green
                                      && RePassword_StatusLabel.BackColor == Color.Green;

    private void IsAdmin_Checkbox_CheckedChanged(object sender, EventArgs e)
    {
      label5.Visible =
        KeyAdmin_Textbox.Visible =
          KeyAdmin_StatusLabel.Visible = IsAdmin_Checkbox.Checked;
    }
  }
}
