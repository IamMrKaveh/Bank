namespace Bank.Structure.Message
{
  public partial class MessageClass
  {
    public void IncorrectInformation()
    {
      string persianMessage = "اطلاعات نادرست هست";
      string englishMessage = "Information is incorrect";

      string persianCaption = "نادرست";
      string englishCaption = "Incorrect";
      
      new MessageClass(
          $"{persianMessage} \n {englishMessage}", 
          $"{persianCaption} || {englishCaption}")
        .Error();
    }
  }
}
