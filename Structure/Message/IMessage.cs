namespace Bank.Structure.Message
{
  public interface IMessage
  {
    string _matn { get; set; }
    
    string _caption { get; set; }
    
    bool _yes_no { get; set; }
  }
}
