using System.Windows.Forms;

namespace Bank.Structure.Message
{
  public partial class MessageClass
  {
    public void MissionStopped()
    {
      string persianMessage = "عملیات متوقف شد";
      string englishMessage = "Mission stopped";

      string persianCaption = "توقف";
      string englishCaption = "Stopped";

      new MessageClass(
        $"{persianMessage} \n {englishMessage}", 
        $"{persianCaption} || {englishCaption}")
        .Information();
    }
  }
}
