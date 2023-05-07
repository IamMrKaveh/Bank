namespace Bank.Structure.Message
{
  public partial class MessageClass
  {
    public void Fail()
    {
      string persianMessage = "متاسفانه عملیات انجام نشد";
      string englishMessage = "Unfortunately Operation Failed";

      string persianCaption = "ناموفق";
      string englishCaption = "Failed";
      
      new MessageClass(
          $"{persianMessage} \n {englishMessage}", 
          $"{persianCaption} || {englishCaption}")
        .Error();
    }
  }
}
