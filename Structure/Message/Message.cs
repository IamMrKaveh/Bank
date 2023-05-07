namespace Bank.Structure.Message
{
    public partial class MessageClass : IMessage
    {
        #region Properties

        public string _matn { get; set; }
        
        public string _caption { get; set; }
        
        public bool _yes_no { get; set; }

        #endregion

        #region Constructure

        public MessageClass(string matn = "", string caption = "", bool yes_no = false)
        {
            _matn = matn;
            _caption = caption;
            _yes_no = yes_no;
        }

        #endregion
    }
}
