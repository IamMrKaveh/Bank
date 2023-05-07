namespace Bank.Structure.Message
{
  public partial class MessageClass
  {
    public void Success()
    {
      string persianMessage = "عملیات با موفقیت انجام شد";
      string englishMessage = "Operation Done Successfuly";

      string persianCaption = "موفقیت آمیز";
      string englishCaption = "Success";
      
      new MessageClass(
          $"{persianMessage} \n {englishMessage}", 
          $"{persianCaption} || {englishCaption}")
        .Information();
    }
  }
}
