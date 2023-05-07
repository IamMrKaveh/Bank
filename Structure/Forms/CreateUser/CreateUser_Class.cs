using System;
using System.Threading.Tasks;
using Bank.Structure.Message;
using Bank.Structure.Models;

namespace Bank.Structure.Forms.CreateUser
{
  public partial class CreateUser_Form
  {
    private bool IsUserAdmin() => IsAdmin_Checkbox.Checked;

    private bool UserCommit()
    {
      string persianMatn = "آیا مطمئن هستین که اکانت را ایجاد کنید";
      string englishMatn = "are you sure to create Account";

      string persianCaption = "تایید";
      string englishCaption = "Approve";

      return new MessageClass(
        $"{persianMatn} \n {englishMatn}",
        $"{persianCaption} || {englishCaption}")
        .Question();
    }

    private async Task AddUser_TO_Databse()
    {
      await Task.Run(new Action(() =>
      {
        string username = Username_Textbox.Text.Trim(),
          password = Password_Textbox.Text.Trim();

        EncryptedUsers newUser = new EncryptedUsers()
        {
          EncryptedUsername = username,
          EncryptedPassword = password,
        };

        bool isSuccess = new User(newUser).Create();

        if (isSuccess)
        {
          Clean();

          new MessageClass().Success();
        }
        else
        {
          new MessageClass().Fail();
        }
      }));
      
    }

    private async Task AddAdmin_TO_Databse()
    {
      
    }
  }
}
